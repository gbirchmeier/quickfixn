using System;
using System.Collections.Generic;
using System.IO;

namespace DDTool.Generators;

public static class GenCsproj {
    private static string ProjFilePath(string outputDir, string ddName) {
        return Path.Join(outputDir, $"{ddName}.csproj");
    }

    public static bool IsExistingCsproj(string outputDir, string ddName) {
        return File.Exists(
            ProjFilePath(outputDir, ddName));
    }

    public static string WriteFile(string outputDir, string ddName) {
        string csprojPath = ProjFilePath(outputDir, ddName);
        File.WriteAllText(csprojPath, Generate(ddName));
        return csprojPath;
    }

    private static string Generate(string name) {
        var lines = new List<string>
        {
            "<Project Sdk=\"Microsoft.NET.Sdk\">",
            "  <!--",
            "      This is a generated file.  HOWEVER, it is only generated if it doesn't already exist.",
            "      If you want it regenerated, you must delete it.",
            "      You can delete this message when you make changes.",
            "  -->",
            "",
            "  <PropertyGroup>",
            "    <TargetFramework>net10.0</TargetFramework>",
            $"    <Description>Custom '{name}' build of QF/n message definitions</Description>",
            "    <Nullable>enable</Nullable>",
            "  </PropertyGroup>",
            "",
            "  <ItemGroup>",
            $"    <ProjectReference Include=\"path/to/QuickFIXn/QuickFix.csproj\" />",
            "  </ItemGroup>",
            "</Project>",
            ""
        };

        return string.Join(Environment.NewLine, lines);
    }
}
