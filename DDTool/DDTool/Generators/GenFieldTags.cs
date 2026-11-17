using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using DDTool.Structures;

namespace DDTool.Generators;

/// <summary>
/// Generates QuickFIXn/Fields/FieldTags.cs
/// </summary>
public static class GenFieldTags {
    /// <summary>
    /// Returns path of file that is written
    /// </summary>
    /// <param name="dd"></param>
    /// <param name="outputDir"></param>
    /// <param name="namespase"></param>
    /// <returns></returns>
    public static string WriteFile(DataDictionary dd, string outputDir, string namespase) {
        string fieldTagsPath = Path.Join(outputDir, "Fields", "FieldTags.cs");
        File.WriteAllText(fieldTagsPath, Generate(namespase, dd.FieldsByTag.Values.ToList()));
        return fieldTagsPath;
    }

    private static string Generate(string namespase, List<DDField> fields) {
        fields = fields.OrderBy(f => f.Tag).ToList();

        var lines = new List<string>
        {
            "// This is a generated file.  Don't edit it directly!",
            "",
            $"namespace {namespase}.Fields;",
            "",
            "/// <summary>",
            "/// FIX Field Tag Values",
            "/// </summary>",
            "public static class Tags",
            "{"
        };

        foreach (var fld in fields)
            lines.Add($"    public const int {fld.Name} = {fld.Tag};");

        lines.Add("}");
        lines.Add("");

        return string.Join(Environment.NewLine, lines);
    }
}
