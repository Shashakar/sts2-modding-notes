# Deployment

## Do not copy full Debug output

The Godot/.NET Debug folder may contain extra files such as:

```text
GodotSharp.dll
GodotSharpEditor.dll
*.deps.json
*.runtimeconfig.json
*.pdb
```

Do not blindly copy the whole Debug folder into `mods/`.

## Confirmed minimal DLL deployment

For a DLL-only Harmony mod, this was enough:

```text
Slay the Spire 2/
  mods/
    ExampleMod/
      ExampleMod.dll
      ExampleMod.json
      0Harmony.dll
```

If using a `.pck`, the manifest must match:

```json
"has_pck": true
```

If not using a `.pck`:

```json
"has_pck": false
```
