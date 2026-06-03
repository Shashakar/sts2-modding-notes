# Run Tracker Notes

The RunTracker mod validated the current known lifecycle hooks.

## Responsibilities

The mod should:

```text
Detect run start
Attach lobby roster if available
Write one JSONL event
Optionally attempt non-blocking upload later
```

The mod should not:

```text
Own the web dashboard
Own Jira/Slack integrations
Block gameplay on network calls
Lose events if upload fails
```

## Confirmed event flow

1. Lobby hook captures roster and platform display names.
2. `RunState.CreateForNewRun` fires.
3. `RunStartedEvent` is written to local JSONL.
4. Optional uploader can process JSONL later.

## Recommended architecture

```text
Mod:
  Writes local JSONL

Uploader:
  Reads JSONL
  Sends events to API
  Retries safely

Website/API:
  Stores and displays runs
```
