using System.ComponentModel.DataAnnotations;
using CodeGeneration;
using CodeGeneration.CSharp;
using Core.Yaml;
using McMaster.Extensions.CommandLineUtils;
using NJsonSchema.CodeGeneration.CSharp;

namespace OpenApiToRefit.Cli;

public class Program
{
    public static int Main(string[] args)
        => CommandLineApplication.Execute<Program>(args);


    [Option(ShortName = "c", Description = "ClassName")]
    [Required]
    public string ClassName { get; } = null!;

    [Option(ShortName = "n", Description = "Namespace")]
    [Required]
    public string Namespace { get; } = null!;

    [Option(ShortName = "u", Description = "OpenApiUrl")]
    [Required]
    public string OpenApiUrl { get; } = null!;

    public async Task OnExecute()
    {
        // https://distribution.nextpax.app/api/swagger/swagger.yaml
        var document = await OpenApiYamlDocument.FromUrlAsync(OpenApiUrl);

        var settings = new CSharpClientGeneratorSettings
        {
            ClassName = ClassName,
            GenerateClientClasses = true,
            GenerateExceptionClasses = false,
            GenerateClientInterfaces = true,
            CSharpGeneratorSettings =
            {
                GenerateDataAnnotations = false,
                TemplateDirectory = "./Templates",
                Namespace = Namespace,
                JsonLibrary = CSharpJsonLibrary.SystemTextJson
            },
            CodeGeneratorSettings =
            {
                TemplateDirectory = "./Templates"
            },
        };
        var generator = new CSharpClientGenerator(document, settings);
        var source = generator.GenerateFile(ClientGeneratorOutputType.Contracts);

        Console.Write(source);
    }
}