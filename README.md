# OpenApi to Refit

A simple tool to generate C# clients from OpenApi format using [Refit: The automatic type-safe REST library](https://github.com/reactiveui/refit).

## How to use
Open a powershell or cmd and run this command
```
dotnet tool install --global OpenApiToRefit.Cli --version 1.0.1
```
Then you can use cli like this:
``` 
OpenApiToRefit -i PetStoreProxyApi -n PetStore -u https://raw.githubusercontent.com/OAI/OpenAPI-Specification/main/examples/v3.0/petstore.yaml
```
```
Options:
  -i|--interface-name <CLASS_NAME>            The Interface name.
  -n|--namespace <NAMESPACE>                  The namespace for generated interface.
  -u|--openapi-url <OPEN_API_URL>             The url of the OpenApi.
  -o|--output-path <OUTPUT_PATH>              The output path of generated files.
  -nullable|--nullable                        Generate nullable reference types?
  -optional-parameters|--optional-parameters  Generate Optional Parameters?
  -?|-h|--help                                Show help information.
  ```



## How to build
1. Open the sln in visual studio 2022
2. Build the sln.
