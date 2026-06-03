# Harmony Patching

Harmony worked for patching STS2 runtime methods from a DLL mod.

## Bootstrap

```csharp
using HarmonyLib;
using MegaCrit.Sts2.Core.Logging;
using MegaCrit.Sts2.Core.Modding;

namespace FirstMod;

[ModInitializer("ModLoaded")]
public static class FirstMod
{
    private static Harmony? _harmony;

    public static void ModLoaded()
    {
        try
        {
            Log.Warn("[RunTracker] Mod loaded.");

            _harmony = new Harmony("dextarm.sts2.runtracker");
            RunStartPatcher.TryPatch(_harmony);

            Log.Warn("[RunTracker] Patch setup completed.");
        }
        catch (Exception ex)
        {
            Log.Error($"[RunTracker] Failed during ModLoaded: {ex}");
        }
    }
}
```

## Important finding: use `__args`

**Status:** Confirmed

Harmony name binding for original method parameters was unreliable in this environment.

This did not reliably bind:

```csharp
private static void Postfix(
    object? players,
    object? acts,
    object? modifiers,
    object? gameMode,
    int ascensionLevel,
    string? seed)
```

This worked:

```csharp
private static void Postfix(object? __result, object[] __args)
{
    object? players = __args.Length > 0 ? __args[0] : null;
    object? acts = __args.Length > 1 ? __args[1] : null;
    object? modifiers = __args.Length > 2 ? __args[2] : null;
    object? gameMode = __args.Length > 3 ? __args[3] : null;
    object? ascensionLevel = __args.Length > 4 ? __args[4] : null;
    object? seed = __args.Length > 5 ? __args[5] : null;
}
```

## Safe patching practices

- Log patch success.
- Catch exceptions during patch setup.
- Avoid blocking work inside postfixes.
- Do not make synchronous HTTP calls from patched game methods.
- Write local data first, upload later or asynchronously.
