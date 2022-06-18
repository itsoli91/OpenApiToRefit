using System.ComponentModel.DataAnnotations;
using System.Text;
using McMaster.Extensions.CommandLineUtils;
using NJsonSchema.CodeGeneration.CSharp;
using NSwag;
using NSwag.CodeGeneration;
using NSwag.CodeGeneration.CSharp;

// ReSharper disable ReplaceAutoPropertyWithComputedProperty

namespace OpenApiToRefit.Cli;

public class Program
{
    public static int Main(string[] args)
        => CommandLineApplication.Execute<Program>(args);


    [Option(ShortName = "i", Description = "The Interface name.", LongName = "interface-name")]
    [Required]
    public string ClassName { get; } = null!;

    [Option(ShortName = "n", Description = "The namespace for generated interface.", LongName = "namespace")]
    [Required]
    public string Namespace { get; } = null!;

    [Option(ShortName = "u", Description = "The url of the OpenApi.", LongName = "openapi-url")]
    [Required]
    public string OpenApiUrl { get; } = null!;

    [Option(ShortName = "o", Description = "The output path of generated files?", LongName = "output-path")]
    public string? OutputPath { get; } = string.Empty;

    [Option(ShortName = "nullable", Description = "Generate nullable reference types?", LongName = "nullable")]
    public bool GenerateNullableReferenceTypes { get; } = true;

    [Option(ShortName = "optional-parameters", Description = "Generate Optional Parameters?",
        LongName = "optional-parameters")]
    public bool GenerateOptionalParameters { get; } = true;

    public async Task OnExecute()
    {
        var templateDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Templates");

        OpenApiDocument? document;

        if (OpenApiUrl.EndsWith(".yml") || OpenApiUrl.EndsWith(".yaml"))
            document = await OpenApiYamlDocument.FromUrlAsync(OpenApiUrl);
        else document = await OpenApiDocument.FromUrlAsync(OpenApiUrl);

        var settings = new CSharpClientGeneratorSettings
        {
            ClassName = ClassName,
            GenerateClientClasses = true,
            GenerateExceptionClasses = false,
            GenerateClientInterfaces = true,
            GenerateOptionalParameters = GenerateOptionalParameters,
            CSharpGeneratorSettings =
            {
                GenerateNullableReferenceTypes = GenerateNullableReferenceTypes,
                GenerateDataAnnotations = false,
                TemplateDirectory = templateDirectory,
                Namespace = Namespace,
                JsonLibrary = CSharpJsonLibrary.SystemTextJson,
            },
            CodeGeneratorSettings =
            {
                TemplateDirectory = templateDirectory
            }
        };
        var cSharpClientGenerator = new CSharpClientGenerator(document, settings);
        var source = cSharpClientGenerator.GenerateFile(ClientGeneratorOutputType.Contracts);

        var path = $"I{ClassName}.cs";
        if (!string.IsNullOrEmpty(OutputPath))
            path = Path.Combine(OutputPath, path);

        await using var sw = new StreamWriter(path, false, Encoding.UTF8);
        await sw.WriteLineAsync(source);
    }
}