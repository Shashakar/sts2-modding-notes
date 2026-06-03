# Mod Loading

## Minimal initializer

**Status:** Confirmed

```csharp
using MegaCrit.Sts2.Core.Logging;
using MegaCrit.Sts2.Core.Modding;

namespace FirstMod;

[ModInitializer("ModLoaded")]
public static class FirstMod
{
    public static void ModLoaded()
    {
        Log.Warn("[FirstMod] Loaded.");
    }
}
```

## Minimal manifest

For a DLL-only mod:

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

## Runtime confirmation

A mod is confirmed to load when:

- STS2 prompts to trust/load mods, or starts in modded mode
- The initializer logs output
- The mod can write a diagnostic file

For the RunTracker mod, diagnostics were written to:

```text
%APPDATA%\STS2RunTracker\diagnostics.log
```
