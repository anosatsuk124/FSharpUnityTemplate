# F# Unity Template

The experimental game template with F#.

## Pre-requisites

- Unity 2022.3.0f1
- dotnet CLI
- direnv (optional, but recommended)

## Pre-configurations

1. Put the `.envrc` file on the project root. The sample content is below:

```bash
export UNITYENGINE_DLL_ROOT='\Applications\Unity\Hub\Editor\2022.3.0f1\Unity.app\Contents\Managed\UnityEngine'
```

2. Watch the file changes and build the project automatically.

```bash
cd FSharp
dotnet watch publish
```
