using System;
using System.Collections.Generic;
using System.Linq;

namespace DDTool;

public class Options {
    public enum ToolCommand
    {
        Unset,
        Analyze,
        Generate,
    }

    public ToolCommand Command { get; }

    public string DDFile { get; }

    /// <summary>
    /// Only set when Command==Generate
    /// </summary>
    public string? OutputDir { get; }

    /// <summary>
    /// Only set when Command==Generate
    /// </summary>
    public string? Namespace { get; }

    public static Options ConstructFromArgs(string[] args)
    {
        Options ops = new(args);
        ops.Validate();
        return ops;
    }

    /// <summary>
    /// If there is a problem, this will throw an exception.
    /// Else it does nothing.
    /// </summary>
    private void Validate()
    {
        if (Command == ToolCommand.Unset)
            throw new Exception("You didn't specify a command.  See the DDTool README");
        if (DDFile is null)
            throw new Exception("No DD file parameter");
        if (Command == ToolCommand.Generate)
        {
            if (OutputDir is null)
                throw new Exception("'generate' mode requires --outputdir");
            if (Namespace is null)
                throw new Exception("'generate' mode requires --namespace");
        }
    }

    private Options(string[] args)
    {
        DDFile = ""; // to satisfy non-null; will be set for real below (unless exception)

        var argList = new LinkedList<string>(args);
        while (argList.Count > 0)
        {
            var next = argList.First();
            argList.RemoveFirst();

            if (next.Contains('=')) {
                var splist = next.Split("=");
                next = splist[0];
                argList.AddFirst(splist[1]);
            }

            switch (next)
            {
                case "--command":
                    string commandStr = argList.First().ToLowerInvariant();
                    argList.RemoveFirst();
                    Command = commandStr switch
                    {
                        "analyze" => ToolCommand.Analyze,
                        "generate" => ToolCommand.Generate,
                        _ => throw new Exception(
                            $"Value for --command must be 'Analyze' or 'Generate' (but it's '{commandStr}')")
                    };
                    break;

                case "--outputdir":
                    OutputDir = argList.First();
                    argList.RemoveFirst();
                    break;

                case "--namespace":
                    Namespace = argList.First();
                    argList.RemoveFirst();
                    break;

                default:
                    if (next.StartsWith("-"))
                        throw new Exception($"Unrecognized option: {next}");

                    // There should be only 1 more param: a DD file.
                    if (!next.EndsWith(".xml"))
                        throw new Exception($"This isn't an xml file: {next}");
                    DDFile = next;

                    if (argList.Count > 0)
                        throw new Exception("Too many params; only one DD is allowed.");

                    break;
            }

        }
    }
}
