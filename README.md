# Dev String Theory — A C# Metaphor for String Theory

This project is a **developer-focused conceptual model** of string theory implemented in C# and ASP.NET/Blazor.

It is **not a physics simulation**—it is a teaching tool that maps physics ideas to software concepts like abstraction, polymorphism, runtime discovery, and factories.

## The simple idea (for junior C# devs + junior physics students)

Think of this project like one shared story told in two languages:

- **C# language:** classes, inheritance, and factories.
- **Physics language:** strings, vibrations, and particles.

The core metaphor is:

1. There is one base concept: a `StringBase` class.
2. Different subclasses (`Electron`, `Photon`, etc.) represent different **vibration patterns**.
3. In physics terms, different vibration patterns of one underlying string look like different particles.
4. In C# terms, different derived classes from one base type look like different runtime behaviors.

So when you run this app and select `Electron` or `Photon`, you are not creating different "things" from scratch—you are seeing different outcomes from one shared foundation.

### Why this helps a C# learner

- If you already understand **inheritance**, imagine each particle as a specialized class.
- If you understand **polymorphism**, imagine the app handling many particle classes through one common base type.
- If you understand a **factory**, `StringFactory` is the place where a specific manifestation is chosen at runtime.

### Why this helps a physics learner

- Real string theory says particles may be different vibrational states of a deeper object (a string).
- This project mirrors that idea in code: one parent abstraction, many child manifestations.
- The goal is intuition, not perfect physical accuracy.

### One-line takeaway

**Physics view:** one string, many vibrations, many observed particles.
**C# view:** one base class, many derived types, many observed behaviors.

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
