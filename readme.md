## DotLiquid.Cli is a project to run locally DotLiquid transformation

Usage

```powershell
# restore and build
dotnet restore
dotnet build -o out

# run transformation
# DotLiquid.exe <liquid template file> <json input data>
./out/DotLiquid.Cli.exe template.liquid data.json
```

For Azure Logic App, your input data is wrapped into a "content" object. To simulate this, you can wrap your sample data in a "content" root node. (See data.json sample file)