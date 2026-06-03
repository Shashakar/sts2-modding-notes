# Minimal DLL Mod

## Manifest

```json
{
  "id": "FirstMod",
  "name": "First Mod",
  "author": "Dex Armstrong",
  "description": "Minimal DLL mod.",
  "version": "0.1.0",
  "has_pck": false,
  "has_dll": true,
  "dependencies": [],
  "affects_gameplay": false
}
```

## Initializer

```csharp
using MegaCrit.Sts2.Core.Logging;
using MegaCrit.Sts2.Core.Modding;

namespace FirstMod;

[ModInitializer("ModLoaded")]
public static class FirstMod
{
    public static void ModLoaded()
    {
        Log.Warn("[FirstMod] Loaded successfully.");
    }
}
```

## Deployment

```text
Slay the Spire 2/
  mods/
    FirstMod/
      FirstMod.dll
      FirstMod.json
```
