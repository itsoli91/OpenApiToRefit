# OpenApi to Refit

A simple tool to generate C# clients from OpenApi format using [Refit: The automatic type-safe REST library](https://github.com/reactiveui/refit).

## How to use
1. Download a zip file from releases.
2. Unzip and open a powershell inside the directory.
3. Use cli commands to generate client. 
4. It will generate a .cs file with provided name inside root dir or defined one.
```
Options:
  -i|--interface-name <CLASS_NAME>            Interface name
  -n|--namespace <NAMESPACE>                  The namespace for generated interface
  -u|--openapi-url <OPEN_API_URL>             The url of the OpenApi.
  -o|--output-path <OUTPUT_PATH>              The url of the OpenApi.
  -nullable|--nullable                        Generate nullable reference types
  -optional-parameters|--optional-parameters  Generate Optional Parameters
  -?|-h|--help                                Show help information.
  ```

Example:

``` 
.\OpenApiToRefit.Cli.exe -i PetStoreProxyApi -n PetStore -u https://raw.githubusercontent.com/OAI/OpenAPI-Specification/main/examples/v3.0/petstore.yaml
```
## How to build
1. Open the sln in visual studio 2022
2. Build the project
