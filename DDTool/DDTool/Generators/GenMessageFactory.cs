using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using DDTool.Structures;

namespace DDTool.Generators;

public static class GenMessageFactory {
    /// <summary>
    /// Returns path of file that is written
    /// </summary>
    /// <param name="dd"></param>
    /// <param name="outputDir"></param>
    /// <param name="namespase"></param>
    /// <returns></returns>
    public static string WriteFile(DataDictionary dd, string outputDir, string namespase) {
        string filePath = Path.Join(outputDir, "MessageFactory.cs");
        File.WriteAllText(filePath, Generate(dd, namespase));
        return filePath;
    }

    private static string Generate(DataDictionary dd, string namespase)
    {
        List<DDMessage> messages = dd.Messages.Values.OrderBy(m => m.Name).ToList();

        var lines = new List<string>
        {
            "// This is a generated file.  Don't edit it directly!",
            "",
            "using System.Collections.Generic;",
            "using QuickFix;",
            "using QuickFix.FixValues;",
            "",
            $"namespace {namespase};",
            "",
            "public class MessageFactory : IMessageFactory",
            "{",
            "    public ICollection<string> GetSupportedBeginStrings()",
            "    {",
            $"       return new [] {{ BeginString.{dd.IdentifierNoDots} }};",
            "    }",
            "",
            "    public QuickFix.Message Create(string beginString, QuickFix.Fields.ApplVerID applVerId, string msgType)",
            "    {",
            "        return Create(beginString, msgType);",
            "    }",
            "",
            "    public QuickFix.Message Create(string beginString, string msgType)",
            "    {",
            "        return msgType switch",
            "        {"
        };

        foreach (DDMessage msg in messages) {
            var fullname = $"{namespase}.{msg.Name}";
            lines.Add(new string(' ', 12) + $"{fullname}.MsgType => new {fullname}(),");
        }

        lines.AddRange(new List<string>
        {
            "            _ => new QuickFix.Message()",
            "        };",
            "    }",
            "",
            "    public Group? Create(string beginString, string msgType, int correspondingFieldId)",
            "    {"
        });

        foreach (DDMessage msg in messages) {

            List<DDGroup> groups = msg.Groups.OrderBy(grp => grp.Name).ToList();
            if (groups.Count == 0)
                continue;

            List<string> xLines =
            [
                $"if ({namespase}.{msg.Name}.MsgType.Equals(msgType))",
                "{",
                "    switch (correspondingFieldId)",
                "    {"
            ];

            foreach (var group in groups) {
                AppendGroupCases(xLines, group, $"{namespase}.{msg.Name}", namespase);
            }

            xLines.Add("    }");
            xLines.Add("}");

            // indent lines
            lines.AddRange(xLines.Select(xl => new string(' ', 8) + xl));
            lines.Add("");
        }

        lines.AddRange(new List<string>{
            "        return null;",
            "    }",
            "}",
            ""
        });

        return string.Join(Environment.NewLine, lines);
    }

    private static void AppendGroupCases(List<string> lines, DDGroup group, string namePath, string namespase) {
        var newNamePath = $"{namePath}.{group.Name}Group";
        lines.Add(
            $"        case {namespase}.Fields.Tags.{group.Name}: return new {newNamePath}();");

        var subgroups = group.Elements.Values.OfType<DDGroup>();
        foreach (var subgroup in subgroups) {
            AppendGroupCases(lines, subgroup, newNamePath, namespase);
        }
    }
}

