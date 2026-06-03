# STS2 Modding Notes

A practical knowledge base for Slay the Spire 2 modding discoveries.

These notes collect confirmed findings from real mod development, runtime testing, and reflection against local copies of `sts2.dll` and `BaseLib.dll`.

!!! warning "Scope"
    This is a living notebook, not a complete modding framework. Treat generated API pages as shape/reference material, not confirmed runtime behavior.

## Start here

- [Getting Started](getting-started.md) for the basic DLL modding workflow.
- [Environment Setup](environment-setup.md) for the confirmed Godot/.NET setup.
- [Mod Loading](mod-loading.md) for a minimal initializer and manifest.
- [Common Errors](common-errors.md) for failure modes that have already bitten this project.

## Most useful findings

- [Known Hooks](known-hooks.md) lists confirmed, potential, and possible hooks.
- [Run Lifecycle](run-lifecycle.md) documents the confirmed run-start hook.
- [Multiplayer Lobby](multiplayer-lobby.md) captures the multiplayer roster findings.
- [Harmony Patching](harmony-patching.md) records the working Harmony setup and `__args` finding.
- [Useful Types](useful-types.md) summarizes runtime types useful for run-state inspection.

## Research leads

- [Community Research](community-research.md) maps public docs, GitHub repositories, and web-discovered leads.
- [Potential Methods](references/potential-methods/README.md) stores metadata-discovered method candidates before runtime confirmation.

## Raw and generated references

- [Discovery Log](discovery-log.md) preserves the chronological findings.
- [Generated Docs](generated/README.md) explains the generated API notes.
- [Raw References](references/README.md) stores lightly processed discovery material.
- [Sts2Inspector](tools/sts2-inspector.md) documents the local reflection helper.

## Certainty labels

- **Confirmed**: known to be usable, working, and documented.
- **Potential**: found through inspection or discovery, but not yet tested.
- **Possibility**: inferred that something like this may exist, but more research is needed.

Do not present guesses as confirmed facts.
