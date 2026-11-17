using System.Linq;
using System.IO;
using System;
using System.Collections.Generic;
using DDTool.Generators;
using DDTool.Parsers;
using DDTool.Structures;

namespace DDTool;

public static class Program {
    private static void Main(string[] args) {
        Options options = Options.ConstructFromArgs(args);

        Console.WriteLine("Thank you for using the QuickFIX/n DDTool Ten-Thousand.");
        Console.WriteLine("Inputs:");
        Console.WriteLine("* command: " + options.Command);
        Console.WriteLine("* ddfile: " + options.DDFile);
        if (options.Command == Options.ToolCommand.Generate)
        {
            Console.WriteLine("* outputdir: " + options.OutputDir);
            Console.WriteLine("* namespace: " + options.Namespace);
        }

        if (!File.Exists(options.DDFile))
        {
            Console.WriteLine("DD file does not exist: " + options.DDFile);
            Environment.Exit(1);
        }
        if (options.Command == Options.ToolCommand.Generate && !Directory.Exists(options.OutputDir))
        {
            Console.WriteLine($"OutputDir does not exist, creating it: {options.OutputDir}");
            Directory.CreateDirectory(options.OutputDir!);
        }

        DataDictionary? dd = null;
        try {
            dd = DDParser.ParseFile(options.DDFile);
            Console.WriteLine($"Parsed! -- {dd.Identifier}");
        } catch (ApplicationException ex) {
            Console.WriteLine($"Error parsing {options.DDFile}:");
            Console.WriteLine(ex.ToString());
            Environment.Exit(1);
        }

        List<string> errors = DDTool.Validations.FieldValidator.Check(dd);
        Console.WriteLine($"No errors found.");

        if (errors.Count > 0) {
            Console.WriteLine("============================");
            Console.WriteLine("Errors found.  Aborting further actions.");
            foreach (var err in errors)
                Console.WriteLine($"* {err}");
            Environment.Exit(1);
        }

        if (options.Command == Options.ToolCommand.Generate) {
            Console.WriteLine("============================");
            Console.WriteLine("Writing files:");

            Console.WriteLine($"* Wrote " + GenFields.WriteFile(dd, options.OutputDir!, options.Namespace!));
            Console.WriteLine($"* Wrote " + GenFieldTags.WriteFile(dd, options.OutputDir!, options.Namespace!));
            Console.WriteLine($"* Wrote " + GenMessageFactory.WriteFile(dd, options.OutputDir!, options.Namespace!));

            var msgFiles = GenMessages.WriteMessageClassFiles(dd, options.OutputDir!, options.Namespace!);
            Console.WriteLine($"* Wrote {msgFiles.Count} message files");
            Console.WriteLine($"  From {msgFiles.First()}");
            Console.WriteLine($"    to {msgFiles.Last()}");

            if (!GenCsproj.IsExistingCsproj(options.OutputDir!, options.Namespace!)) {
                string projFile = GenCsproj.WriteFile(options.OutputDir!, options.Namespace!);
                Console.WriteLine($"* Created new project file {projFile} (you NEED to review this)");
            }
        }
    }
}
