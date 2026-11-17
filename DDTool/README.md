# DDTool
DataDictionary analyzer/codegen for QuickFIX/n

Starting with 2.0, this program only generates from one Dictionary at a time.

It doesn't do much analyzing yet.

It intentionally has minimal dependencies, and the UTs use
Microsoft's default TestFramework.

## To run

To parse DDs, but only analyze (not generate):  
`> dotnet run --project DDTool --command analyze <DDfile>`

To parse DDs and generate:  
`> dotnet run --project DDTool --command generate --outputdir <destDir> --namespace <namespace> <ddFile>`
