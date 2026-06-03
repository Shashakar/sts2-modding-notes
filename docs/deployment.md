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

For the RunTracker mod, this was enough:

```text
Slay the Spire 2/
  mods/
    FirstMod/
      FirstMod.dll
      FirstMod.json
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

## Dev-machine to test-machine workflow

Recommended workflow:

```text
Development machine:
  Build/package into dist/

Test machine:
  git fetch
  git pull
  copy dist/* into Slay the Spire 2/mods/FirstMod/
```

Avoid turning the handheld/test machine into a second dev environment.
