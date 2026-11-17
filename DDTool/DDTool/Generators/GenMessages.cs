using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using DDTool.Structures;

namespace DDTool.Generators;

public static class GenMessages
{

    /// <summary>
    /// Write the message classes using the DD content
    /// </summary>
    /// <param name="dd"></param>
    /// <param name="outputDir"></param>
    /// <param name="namespase"></param>
    /// <returns>List of filenames that were written</returns>
    public static List<string> WriteMessageClassFiles(DataDictionary dd, string outputDir, string namespase) {
        List<string> rv = [];
        rv.Add(WriteBaseMessageFile(dd, outputDir, namespase));
        foreach (var msg in dd.Messages.Values) {
            rv.Add(WriteMessageFile(msg, dd, outputDir, namespase));
        }

        rv.Sort();
        return rv;
    }

    private static string WriteBaseMessageFile(DataDictionary dd, string outputDir, string namespase) {
        var beginString = dd.IdentifierNoDots.Contains("FIX50") ? "FIXT11" : dd.IdentifierNoDots;
        string filePath = Path.Join(outputDir, "Message.cs");
        Directory.CreateDirectory(
            Path.GetDirectoryName(filePath)!);

        var lines = new List<string>
        {
            "// This is a generated file.  Don't edit it directly!",
            "",
            $"namespace {namespase};",
            "",
            "public abstract class Message : QuickFix.Message",
            "{",
            "    protected Message() : base()",
            "    {",
            $"        Header.SetField(new QuickFix.Fields.BeginString(QuickFix.FixValues.BeginString.{beginString}));",
            "    }",
            "}",
            ""
        };

        File.WriteAllText(filePath, string.Join(Environment.NewLine, lines));

        return filePath;
    }

    private static string WriteMessageFile(DDMessage msg, DataDictionary dd, string outputDir, string namespase) {
        string filePath = Path.Join(outputDir, $"{msg.Name}.cs");
        Directory.CreateDirectory(
            Path.GetDirectoryName(filePath)!);

        var lines = new List<string>
        {
            "// This is a generated file.  Don't edit it directly!",
            "",
            "using System;",
            "using QuickFix;",
            $"using {namespase}.Fields;",
            "",
            $"namespace {namespase};",
            "",
            $"public class {msg.Name} : {namespase}.Message",
            "{",
            $"    public const string MsgType = \"{msg.MsgType}\";",
            "",
            $"    public {msg.Name}() : base()",
            "    {",
            $"        Header.SetField(new QuickFix.Fields.MsgType(\"{msg.MsgType}\"));",
            "    }"
        };

        lines.AddRange(GenerateCtorWithRequiredFields(msg));

        lines.AddRange(GenerateFields(msg, 4));
        lines.AddRange(GenerateGroups(msg, 4));

        lines.Add("}");
        lines.Add("");

        File.WriteAllText(filePath, string.Join(Environment.NewLine, lines));

        return filePath;
    }

    private static List<string> GenerateCtorWithRequiredFields(DDMessage msg) {
        List<string> rv = [];

        List<DDField> requiredFields = msg.RequiredFields;
        if (requiredFields.Count < 1) {
            return rv;
        }

        var reqArgs = requiredFields.Select(rf => $"{new string(' ', 12)}{rf.Name} a{rf.Name}").ToList();
        var reqSetters = requiredFields.Select(rf => $"{new string(' ', 8)}{rf.Name} = a{rf.Name};").ToList();

        rv.Add("");
        rv.Add($"    public {msg.Name}(");
        foreach (string arg in reqArgs) {
            if (arg == reqArgs.Last())
                rv.Add(arg);
            else
                rv.Add(arg + ",");
        }

        rv.Add("        ) : this()");
        rv.Add("    {");
        foreach (var setter in reqSetters) {
            rv.Add(setter);
        }
        rv.Add("    }");

        return rv;
    }

    private static List<string> GenerateFields(IElementSequence seq, int indentSpaces) {
        List<string> rv = [];

        foreach (IElement el in seq.Elements.Values) {
            rv.AddRange(GenerateSingleField(el, seq, indentSpaces));
        }

        return rv;
    }

    private static List<string> GenerateSingleField(IElement field, IElementSequence seq, int indentSpaces) {
        // This function contains special handling for SecurityStatus,
        //   which is the name of both a field and a message.
        //   Its member name is generated as "SecurityStatus_".

        string fldName = field.Name;
        if (field.Name == seq.Name) {
            // A C# member can't have the same name as its enclosing class,
            //   so change SecurityStatus field Property to "SecurityStatus_"
            fldName += "_";
        }

        string fldClass = field.Name;
        if (field.Name == "SecurityStatus")
            fldClass = "Fields.SecurityStatus";

        var lines = new List<string>
        {
            "",
            $"public {fldClass} {fldName}",
            "{",
            "    get",
            "    {",
            $"        {fldClass} val = new();",
            "        GetField(val);",
            "        return val;",
            "    }",
            "    set  => SetField(value);",
            "}",
            "",
            $"public void Set({fldClass} val) {{ {fldName} = val; }}",
            $"public {fldClass} Get({fldClass} val) {{ GetField(val); return val; }}",
            $"public bool IsSet({fldClass} val) {{ return IsSet{field.Name}(); }}",
            $"public bool IsSet{field.Name}() {{ return IsSetField(Fields.Tags.{field.Name}); }}",
        };

        var indent = new string(' ', indentSpaces);
        var rv = lines.Select(line => string.IsNullOrEmpty(line) ? "" : (indent + line)).ToList();
        return rv;
    }

    private static List<string> GenerateGroups(IElementSequence seq, int indentSpaces) {
        List<string> rv = [];

        foreach (DDGroup grp in seq.Groups) {
            rv.AddRange(GenerateSingleGroup(grp, indentSpaces));
        }

        return rv;
    }

    private static List<string> GenerateSingleGroup(DDGroup group, int indentSpaces) {
        List<string> fieldOrderStrings = group.Elements.Values.Select(ddf => $"Fields.Tags.{ddf.Name}").ToList();
        fieldOrderStrings.Add("0"); // TODO all QFs do this, I should figure out why

        var lines = new List<string>
        {
            "",
            $"public class {group.Name}Group : Group",
            "{",
            $"    public static int[] DefaultFieldOrder = [{string.Join(", ", fieldOrderStrings)}];",
            "",
            "    [Obsolete(\"Use DefaultFieldOrder instead.  This will be removed in 1.16.\")]",
            $"    public static int[] fieldOrder = {{{string.Join(", ", fieldOrderStrings)}}};",
            "",
            $"    public {group.Name}Group()",
            $"      : base(Fields.Tags.{group.CounterField.Name}, Fields.Tags.{group.Delimiter.Name}, DefaultFieldOrder)",
            "    {",
            "    }",
            "",
            "    public override Group Clone()",
            "    {",
            $"        var clone = new {group.Name}Group();",
            "        clone.CopyStateFrom(this);",
            "        return clone;",
            "    }"
        };

        lines.AddRange(GenerateFields(group, 4));
        lines.AddRange(GenerateGroups(group, 4));

        lines.Add("}");

        var indent = new string(' ', indentSpaces);
        var rv = lines.Select(line => string.IsNullOrEmpty(line) ? "" : (indent + line)).ToList();
        return rv;
    }
}
