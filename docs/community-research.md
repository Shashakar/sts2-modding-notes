# Community Research

Web pass date: 2026-06-03.

This page collects community documentation and public repository leads for Slay the Spire 2 modding. Treat it as a source map: useful for deciding where to inspect next, but not proof that a hook is stable until runtime-tested locally.

## Highest-value sources

| Source | What it contributes | Notes |
|---|---|---|
| [Alchyr/BaseLib-StS2](https://github.com/Alchyr/BaseLib-StS2) | Shared dependency library, Harmony patch examples, save/content/UI utilities, custom model APIs. | The README describes BaseLib as a dependency base for other mods and points to the BaseLib Wiki and ModTemplate guide. The repository showed latest release `v3.1.8` on 2026-05-26 during this pass. |
| [BaseLib Wiki](https://alchyr.github.io/BaseLib-Wiki/) | User-facing BaseLib API docs. | Good first stop for supported abstractions before writing raw Harmony patches. |
| [Alchyr/ModTemplate-StS2 wiki](https://github.com/Alchyr/ModTemplate-StS2/wiki) | Setup, decompiling workflow, mod basics, project structure, manifest guidance. | The mirrored Modding Basics page says most game content is a `Model`, lifecycle behavior is usually exposed through methods like `OnPlay`, and commands are preferred over direct data mutation. |
| [ModTemplate Decompiling page](https://github-wiki-see.page/m/Alchyr/ModTemplate-StS2/wiki/Decompiling) | Practical workflow for finding methods and patch targets. | Recommends Rider decompilation/search, Find Usages, and locating `sts2.dll` in the game's `data_*` directory. |
| [BAKAOLC/STS2-RitsuLib](https://github.com/BAKAOLC/STS2-RitsuLib) | Alternative shared framework with explicit registration and many domain folders. | Public tree has promising folders including `Lifecycle`, `Patching`, `RunData`, `Saves`, `Combat`, `Cards`, `Relics`, `Settings`, and `Telemetry`. |
| [STS2.GG install guide](https://sts2.gg/mods/install-guide) | Player/mod install expectations and common dependency notes. | Mentions current mod install paths, BaseLib/ModConfig dependency expectations, logs location, and branch/update caveats. |
| [STS2.GG RitsuLib entry](https://sts2.gg/mods/mod-137) | Public package metadata and troubleshooting notes for RitsuLib. | Describes RitsuLib as a BaseLib-like prerequisite for rapid content mod development. |
| [GitHub topic: slay-the-spire-2](https://github.com/topics/slay-the-spire-2) | Discovery list for public mods and tooling. | Useful leads include `spirescope`, `STS2-DevMode`, `sts2-multiplayer-save-slots`, mod managers, save editors, and tutorial repositories. |
| [freude916/sts2-quickRestart](https://github.com/freude916/sts2-quickRestart) | Example public mod plus Chinese modding notes. | Its README notes official modding support with many hooks and Harmony support, and links BaseLib, ModTemplate, RitsuLib, and related projects. |

## What the community sources imply

### Prefer library APIs when available

BaseLib and RitsuLib are both trying to make common mod behaviors less patch-fragile. Before patching a raw game method, check whether BaseLib or RitsuLib already exposes a supported extension point for the same behavior.

Good search areas:

- BaseLib `Hooks/`
- BaseLib `Patches/Hooks/`
- BaseLib `Patches/Saves/`
- BaseLib `Patches/Content/`
- RitsuLib `Lifecycle/`
- RitsuLib `Patching/`
- RitsuLib `RunData/`
- RitsuLib `Saves/`
- RitsuLib `Combat/`

### Use raw Harmony patches for lifecycle tracking

For run tracking, persistence, analytics, and multiplayer roster capture, raw Harmony patches still matter because library abstractions may focus on content registration rather than observation. Community docs repeatedly point modders toward decompilation and Find Usages for patch target discovery.

The local confirmed hooks remain stronger evidence than web mentions:

- `RunState.CreateForNewRun`
- `StartRunLobby.BeginRunLocally`
- `StartRunLobby.BeginRunForAllPlayers`
- `SaveManager.SaveRun`
- `SaveManager.UpdateProgressWithRunData`

### Expect update churn

The ModTemplate wiki calls out frequent Early Access main/beta branch changes. BaseLib generally absorbs many API changes for mods that use its abstractions, while mods with custom patches may need direct updates. This is especially relevant for any raw hook in `docs/known-hooks.md`.

### Be careful with multiplayer

The community docs emphasize `affects_gameplay` and dependency/version matching. Informational or cosmetic mods can sometimes set `affects_gameplay=false`, but doing so incorrectly can cause desyncs. Run tracking, telemetry, or save-export mods should be audited carefully before declaring themselves non-gameplay-affecting.

## Hook and method leads to mine next

These are web-discovered research targets, not confirmed findings.

| Area | Source trail | Why it matters | Local next step |
|---|---|---|---|
| BaseLib save extensions | BaseLib `Patches/Saves/`; BaseLibMain calls `ExtendedSavePatches.Patch(...)`. | Could reveal a supported way to attach data to saves or run histories. | Inspect `ExtendedSavePatches` and related save abstractions; compare with local `SaveManager.SaveRun` and `UpdateProgressWithRunData` patches. |
| BaseLib hook patches | BaseLib `Patches/Hooks/` contains hook patches such as card-play, heal amount, and max hand size areas. | Shows how BaseLib safely extends game lifecycle behavior. | Inspect patch shapes and use them as Harmony examples. |
| RitsuLib run data | RitsuLib `RunData/` contains run saved-data classes, lobby/session classes, registry/runtime/store classes, and a patches folder. | Strong lead for multiplayer-safe run-associated data. | Inspect RunData patch targets and lifecycle timing. |
| RitsuLib patching system | RitsuLib `Patching/` has builder/core/model/rule folders. | May provide reusable patch registration patterns and safeguards. | Identify whether it wraps Harmony and whether its rules help avoid duplicate patching. |
| Dev tooling mods | GitHub topic lists `STS2-DevMode` and `STS2 Modding Assistant MCP`. | Likely useful for finding methods, breakpoints, and runtime inspection flows. | Review public docs/code for method discovery workflows. |
| Companion/run trackers | GitHub topic lists `spirescope` and related companion apps. | They may already solve run-state extraction, save parsing, or event timing. | Inspect whether they read saves externally, patch in-game, or use logs. |
| Multiplayer save slots | GitHub topic lists `sts2-multiplayer-save-slots`. | Promising for lobby/run save paths and multiplayer campaign handling. | Inspect patch targets around `RunLobby`, save slot selection, and host/client behavior. |

## Search queries that worked

```text
Slay the Spire 2 modding GitHub BaseLib hooks MegaCrit.Sts2.Core.Hooks Hook
site:github.com Slay the Spire 2 mod MegaCrit.Sts2.Core.Hooks Hook
site:github.com "MegaCrit.Sts2.Core" "HarmonyPatch" "Slay the Spire 2"
site:github.com "MegaCrit.Sts2" "AfterCombatVictory"
Alchyr BaseLib-StS2 Patches Saves ExtendedSavePatches
```

## Promotion rule

Promote a lead from this page to [Known Hooks](known-hooks.md) only after at least one local runtime test confirms:

- the patch applies,
- the method fires in the intended flow,
- timing is understood well enough to use safely,
- multiplayer/single-player differences are noted when relevant,
- async methods are awaited or observed correctly when reading resulting state.
