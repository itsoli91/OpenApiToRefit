using System.Text;
using NJsonSchema.CodeGeneration.CSharp;
using NSwag;
using NSwag.CodeGeneration.CSharp;

namespace OpenApiToRefit.Cli;

public class RefitGenerator
{
    public async Task Generate()
    {
        var httpClient = new HttpClient
        {
            BaseAddress = new Uri("https://raw.githubusercontent.com/OAI/OpenAPI-Specification/")
        };

        var content = await httpClient.GetStringAsync("main/examples/v3.0/petstore.json");

        var document = await OpenApiDocument.FromJsonAsync(content);

        var settings = new CSharpClientGeneratorSettings
        {
            GenerateClientClasses = true,
            GenerateExceptionClasses = false,
            GenerateClientInterfaces = true,
            CSharpGeneratorSettings =
            {
                Namespace = "PetStore",
                JsonLibrary = CSharpJsonLibrary.SystemTextJson
            }
        };
        var generator = new CSharpClientGenerator(document, settings);
        var code = generator.GenerateFile();

        var lines = code
            .Split(Environment.NewLine.ToCharArray())
            .Skip(5)
            .ToList();
        var result = lines
            .Where(line => !line.Contains("#pragma"))
            .Where(line => !line.Contains("System.CodeDom.Compiler.GeneratedCode"))
            .ToList();

        var output = string.Join(Environment.NewLine, result);

        var sb = new StringBuilder();

        //foreach (var path in document.Paths)
        //{
        //    foreach (var operation in path.Value)
        //    {
        //        sb.AppendLine($@"[{operation.Key}(""{path.Key}"")]");

        //        string responseType = "";

        //        if(responseType.)
        //        sb.AppendLine($@"public {operation.Value.Responses.FirstOrDefault()}");

        //    }
        //}

        sb.AppendLine(output);

        Console.WriteLine(sb.ToString());
    }
}