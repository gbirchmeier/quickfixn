using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using DDTool.Structures;

namespace DDTool.Generators;

/// <summary>
/// Generates Fields.cs
/// </summary>
public static class GenFields {
    /// <summary>
    /// Returns path of file that is written
    /// </summary>
    /// <param name="dd"></param>
    /// <param name="outputDir"></param>
    /// <param name="namespase"></param>
    /// <returns></returns>
    public static string WriteFile(DataDictionary dd, string outputDir, string namespase)
    {
        string dirPath = Path.Join(outputDir, "Fields");
        Directory.CreateDirectory(dirPath); // no effect if already exists

        string fieldsPath = Path.Join(dirPath, "Fields.cs");
        File.WriteAllText(fieldsPath, Generate(namespase, dd.FieldsByTag.Values.ToList()));
        return fieldsPath;
    }

    internal static string Generate(string namespase, List<DDField> fields) {
        fields = fields.OrderBy(f => f.Tag).ToList();

        var lines = new List<string>
        {
            "// This is a generated file.  Don't edit it directly!",
            "",
            "// TODO maybe put this in GlobalUsing.cs",
            "global using SeqNumType = System.UInt64;",
            "global using SeqNumFieldType = QuickFix.Fields.ULongField;",
            "",
            "using System;",
            "",
            $"namespace {namespase}.Fields;",
        };

        foreach (var field in fields) {
            lines.Add("");
            switch (field.CsClass) {
                case "DateTimeField":
                    AppendDateTimeField(lines, field);
                    break;
                case "TimeOnlyField":
                    AppendTimeOnlyField(lines, field);
                    break;
                case "UtcDateTimeField":
                    AppendUtcDateTimeField(lines, field);
                    break;
                default:
                    AppendVanillaField(lines, field);
                    break;
            }
        }

        lines.Add("");
        return string.Join(Environment.NewLine, lines);
    }

    private static void AppendDateTimeField(List<string> lines, DDField field) {
        lines.Add("/// <summary>");
        lines.Add($"/// {field.Name} Field");
        lines.Add("/// </summary>");
        lines.Add($"public sealed class {field.Name} : QuickFix.Fields.{field.CsClass}");
        lines.Add("{");
        lines.Add($"    public const int TAG = {field.Tag};");
        lines.Add("");

        lines.Add($"    public {field.Name}()");
        lines.Add($"        : base(TAG) {{}}");
        lines.Add($"    public {field.Name}({field.BaseType} val)");
        lines.Add($"        : base(TAG, val) {{}}");
        lines.Add("    [Obsolete(\"Use the ctor that takes TimePrecision instead.  This ctor will be removed in 1.15.\")]");
        lines.Add($"    public {field.Name}({field.BaseType} val, bool showMilliseconds)");
        lines.Add($"        : base(TAG, val, showMilliseconds) {{}}");
        lines.Add($"    public {field.Name}({field.BaseType} val, QuickFix.Fields.TimePrecision precision)");
        lines.Add($"        : base(TAG, val, precision) {{}}");

        AppendFieldEnumerations(lines, field);

        lines.Add("}");
    }

    private static void AppendTimeOnlyField(List<string> lines, DDField field) {
        lines.Add("/// <summary>");
        lines.Add($"/// {field.Name} Field");
        lines.Add("/// </summary>");
        lines.Add($"public sealed class {field.Name} : QuickFix.Fields.{field.CsClass}");
        lines.Add("{");
        lines.Add($"    public const int TAG = {field.Tag};");
        lines.Add("");

        lines.Add($"    public {field.Name}()");
        lines.Add($"        : base(TAG) {{}}");
        lines.Add($"    public {field.Name}({field.BaseType} val)");
        lines.Add($"        : base(TAG, val) {{}}");
        lines.Add($"    public {field.Name}({field.BaseType} val, QuickFix.Fields.TimePrecision precision)");
        lines.Add($"        : base(TAG, val, precision) {{}}");
        lines.Add("}");
    }

    private static void AppendUtcDateTimeField(List<string> lines, DDField field)
    {
        string utcWarning = """

                                /// <summary>
                                /// IMPORTANT: If <c>val.Kind</c> is <c>Local</c>, then val
                                /// will be converted to UTC and this UTC-adjusted time will be in the FIX string
                                /// </summary>
                                /// <param name="val"></param>
                            """.TrimEnd();


        lines.Add("/// <summary>");
        lines.Add($"/// {field.Name} Field");
        lines.Add("/// </summary>");
        lines.Add($"public sealed class {field.Name} : QuickFix.Fields.{field.CsClass}");
        lines.Add("{");
        lines.Add($"    public const int TAG = {field.Tag};");
        lines.Add("");

        lines.Add($"    public {field.Name}()");
        lines.Add($"        : base(TAG) {{}}");
        lines.Add(utcWarning);
        lines.Add($"    public {field.Name}({field.BaseType} val)");
        lines.Add($"        : base(TAG, val) {{}}");
        lines.Add(utcWarning);
        lines.Add("    /// <param name=\"showMilliseconds\"></param>");
        lines.Add("    [Obsolete(\"Use the ctor that takes TimePrecision instead.  This ctor will be removed in 1.15.\")]");
        lines.Add($"    public {field.Name}({field.BaseType} val, bool showMilliseconds)");
        lines.Add($"        : base(TAG, val, showMilliseconds) {{}}");
        lines.Add(utcWarning);
        lines.Add("    /// <param name=\"precision\"></param>");
        lines.Add($"    public {field.Name}({field.BaseType} val, QuickFix.Fields.TimePrecision precision)");
        lines.Add($"        : base(TAG, val, precision) {{}}");
        lines.Add("}");
    }

    private static void AppendVanillaField(List<string> lines, DDField field)
    {
        string klass = field.CsClass == "SeqNumFieldType" ? "SeqNumFieldType" : $"QuickFix.Fields.{field.CsClass}";

        lines.Add("/// <summary>");
        lines.Add($"/// {field.Name} Field");
        lines.Add("/// </summary>");
        lines.Add($"public sealed class {field.Name} : {klass}");
        lines.Add("{");
        lines.Add($"    public const int TAG = {field.Tag};");
        lines.Add("");

        lines.Add($"    public {field.Name}()");
        lines.Add("        : base(TAG) {{}}");
        lines.Add($"    public {field.Name}({field.BaseType} val)");
        lines.Add("        : base(TAG, val) {{}}");

        AppendFieldEnumerations(lines, field);

        lines.Add("}");
    }

    private static void AppendFieldEnumerations(List<string> lines, DDField field) {
        if (field.Enums.Count < 1)
            return;

        lines.Add("");
        lines.Add("    // Field Enumerations");

        foreach (var enumVal in field.Enums) {
            string desc = enumVal.Desc.Replace('.', '_');

            if (Regex.IsMatch(desc, @"^(\d+)(.*)")) {
                desc = $"VAL_{desc}";
            }

            string outVal = field.BaseType switch
            {
                "int" => enumVal.Val,
                "string" => $"\"{enumVal.Val}\"",
                "char" => $"'{enumVal.Val}'",
                "Boolean" => enumVal.Val == "Y" ? "true" : "false",
                _ => throw new Exception(
                    $"unsupported field type '{field.BaseType}' ({field})")
            };

            lines.Add($"    public const {field.BaseType} {desc} = {outVal};");
        }
    }
}
