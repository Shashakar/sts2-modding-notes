# Mod Loading

## Minimal initializer

**Status:** Confirmed

```csharp
using MegaCrit.Sts2.Core.Logging;
using MegaCrit.Sts2.Core.Modding;

namespace ExampleMod;

[ModInitializer("ModLoaded")]
public static class ExampleMod
{
    public static void ModLoaded()
    {
        Log.Warn("[ExampleMod] Loaded.");
    }
}
```

## Minimal manifest

For a DLL-only mod:

```json
{
  "id": "ExampleMod",
  "name": "Example Mod",
  "author": "Your Name",
  "description": "Minimal DLL mod.",
  "version": "0.1.0",
  "has_pck": false,
  "has_dll": true,
  "dependencies": [],
  "affects_gameplay": false
}
```

## Runtime confirmation

A mod is confirmed to load when:

- STS2 prompts to trust/load mods, or starts in modded mode
- The initializer logs output
- The mod can write a diagnostic file
