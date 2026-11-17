using System.Collections.Generic;
using DDTool.Generators;
using DDTool.Structures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Generators;

[TestClass]
public class GenFieldsTests {

    [TestMethod]
    public void GenerateNamespace()
    {
        List<DDField> fields = [];
        string output = GenFields.Generate("MyNamespace", fields);
        StringAssert.Contains(output, "namespace MyNamespace.Fields;");
    }

    [TestMethod]
    public void GenerateUtcTimestampHasUtcDateTimeFieldBaseClass()
    {
        var fields = new List<DDField> { new(52, "SendingTime", [], "UTCTIMESTAMP") };
        string output = GenFields.Generate("MyNamespace", fields);
        StringAssert.Contains(output,"public sealed class SendingTime : UtcDateTimeField");
    }

    [TestMethod]
    public void GenerateTzTimestampHasDateTimeFieldBaseClass()
    {
        var fields = new List<DDField> { new(1132, "TZTransactTime", [], "TZTIMESTAMP") };
        string output = GenFields.Generate("MyNamespace", fields);
        StringAssert.Contains(output, "public sealed class TZTransactTime : DateTimeField");
    }
}
