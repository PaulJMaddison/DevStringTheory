# Dev String Theory — A C# Metaphor for String Theory

This project is a **developer-focused conceptual model** of string theory implemented in C# and ASP.NET/Blazor.

It is **not a physics simulation**—it is a teaching tool that maps physics ideas to software concepts like abstraction, polymorphism, runtime discovery, and factories.

## Projects

- `DevStringTheory.App` — Console explorer with timeline, noise, and scripted scenarios.
- `DevStringTheory.Tests` — Unit-style runtime checks for discovery and error messaging.
- `DevStringTheory.Web` — Blazor web UI with vibration buttons and explanation cards.

## Console Features

### Vibration exploration

- `--list` to discover available vibration modes at runtime.
- Direct mode selection (`Electron`, `Photon`, etc.).
- `--random` to pick a runtime manifestation.
- `--explain` to print developer analogy + conceptual physics note.

### Timeline mode

- `--timeline` prints historical milestones from early particle discoveries through modern string theory eras.

### Uncertainty/noise mode

- `--noise --repeat <n>` performs repeated conceptual observations with probabilistic output (illustrative only).

### Scripted JSON scenarios

- `--scenario <name-or-path>` loads lesson steps from JSON files.
- Built-in samples are under `DevStringTheory.App/Scenarios`:
  - `beginner-lesson.json`
  - `advanced-lesson.json`

## Example commands

```bash
# List modes
DOTNET_CLI_TELEMETRY_OPTOUT=1 dotnet run --project DevStringTheory/DevStringTheory.App -- --list

# Timeline
DOTNET_CLI_TELEMETRY_OPTOUT=1 dotnet run --project DevStringTheory/DevStringTheory.App -- --timeline

# Explain a specific mode
DOTNET_CLI_TELEMETRY_OPTOUT=1 dotnet run --project DevStringTheory/DevStringTheory.App -- Photon --explain

# Noise mode with repeated observations
DOTNET_CLI_TELEMETRY_OPTOUT=1 dotnet run --project DevStringTheory/DevStringTheory.App -- Electron --noise --repeat 5

# Run scripted lesson
DOTNET_CLI_TELEMETRY_OPTOUT=1 dotnet run --project DevStringTheory/DevStringTheory.App -- --scenario beginner-lesson

# Run unit checks
DOTNET_CLI_TELEMETRY_OPTOUT=1 dotnet run --project DevStringTheory/DevStringTheory.Tests

# Launch Blazor UI
DOTNET_CLI_TELEMETRY_OPTOUT=1 dotnet run --project DevStringTheory/DevStringTheory.Web
```

## Web UI

The Blazor UI provides:

- A button for each discovered vibration mode.
- A card that displays the selected mode’s developer analogy and physics note.

## Concept mapping (code → theory metaphor)

- `StringBase` = one underlying string abstraction.
- Concrete vibration classes (`Electron`, `Photon`, etc.) = different observed manifestations.
- `StringFactory` = universe-level runtime resolution.

## Important note

This project remains a **conceptual metaphor** for software developers and does not claim physical modeling accuracy.
