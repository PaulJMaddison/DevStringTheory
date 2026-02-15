using DevStringTheory.App.Fundamental;
using DevStringTheory.App.Universe;

Console.WriteLine("=== Dev String Theory Explorer ===");
Console.WriteLine("One fundamental string. Many possible vibrations.");
Console.WriteLine();

if (args.Contains("--help", StringComparer.OrdinalIgnoreCase) || args.Contains("-h", StringComparer.OrdinalIgnoreCase))
{
    PrintHelp();
    return;
}

if (args.Contains("--list", StringComparer.OrdinalIgnoreCase))
{
    PrintAvailableVibrations();
    return;
}

if (args.Contains("--timeline", StringComparer.OrdinalIgnoreCase))
{
    PrintTimeline();
    return;
}

if (TryGetOptionValue(args, "--scenario", out var scenarioName))
{
    RunScenario(scenarioName!);
    return;
}

var explainMode = args.Contains("--explain", StringComparer.OrdinalIgnoreCase);
var randomMode = args.Contains("--random", StringComparer.OrdinalIgnoreCase);
var noiseMode = args.Contains("--noise", StringComparer.OrdinalIgnoreCase);
var repeatCount = GetRepeatCount(args);
var selectedMode = args.FirstOrDefault(arg => !arg.StartsWith("--", StringComparison.Ordinal));

if (repeatCount <= 0)
{
    Console.WriteLine("Repeat count must be a positive integer.");
    return;
}

if (!randomMode && string.IsNullOrWhiteSpace(selectedMode))
{
    PrintAvailableVibrations();
    Console.Write("Type a vibration mode to manifest: ");
    selectedMode = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(selectedMode))
    {
        Console.WriteLine("No mode entered. Exiting.");
        return;
    }
}

try
{
    if (noiseMode)
    {
        if (randomMode)
        {
            Console.WriteLine("Noise mode requires a selected mode, not --random.");
            return;
        }

        RunNoisyObservations(selectedMode!.Trim(), repeatCount, explainMode);
    }
    else
    {
        var particle = randomMode
            ? StringFactory.CreateRandomVibration(Random.Shared)
            : StringFactory.CreateVibration(selectedMode!.Trim());

        Console.WriteLine(randomMode
            ? "Random vibration mode selected at runtime."
            : $"Selected vibration mode: {selectedMode!.Trim()}");

        Console.WriteLine("Asking the universe to manifest this vibration...");
        Console.WriteLine();

        particle.Vibrate();

        if (explainMode)
        {
            Console.WriteLine();
            particle.Explain();
        }
    }
}
catch (Exception ex) when (ex is ArgumentException || ex is FileNotFoundException || ex is InvalidDataException)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine("Use --list to see valid options.");
    return;
}

Console.WriteLine();
Console.WriteLine("Observation complete.");
Console.WriteLine("Same fundamental string. Different vibration, different particle.");
Console.WriteLine("===================================");

static void RunNoisyObservations(string mode, int repeatCount, bool explainMode)
{
    Console.WriteLine($"Noisy observation mode for '{mode}' with {repeatCount} observations.");
    Console.WriteLine("Conceptual uncertainty enabled (illustrative only).");

    for (var i = 1; i <= repeatCount; i++)
    {
        var observed = StringFactory.ObserveWithNoise(mode, Random.Shared);
        Console.Write($"Observation {i}: ");
        observed.Vibrate();

        if (explainMode)
        {
            observed.Explain();
            Console.WriteLine();
        }
    }
}

static void RunScenario(string scenarioName)
{
    var scenario = ScenarioLoader.Load(scenarioName);
    Console.WriteLine($"Scenario: {scenario.Title}");
    Console.WriteLine(scenario.Introduction);
    Console.WriteLine();

    foreach (var step in scenario.Steps)
    {
        Console.WriteLine($"--- {step.Label} ---");
        if (!string.IsNullOrWhiteSpace(step.Commentary))
        {
            Console.WriteLine(step.Commentary);
        }

        if (string.IsNullOrWhiteSpace(step.Mode))
        {
            Console.WriteLine("No mode configured for this step.");
            Console.WriteLine();
            continue;
        }

        var repeat = Math.Max(step.Repeat, 1);
        if (step.Noise)
        {
            RunNoisyObservations(step.Mode, repeat, step.Explain);
        }
        else
        {
            for (var i = 1; i <= repeat; i++)
            {
                var particle = StringFactory.CreateVibration(step.Mode);
                if (repeat > 1)
                {
                    Console.Write($"Run {i}: ");
                }

                particle.Vibrate();
                if (step.Explain)
                {
                    particle.Explain();
                }
            }
        }

        Console.WriteLine();
    }
}

static int GetRepeatCount(string[] args)
{
    if (!TryGetOptionValue(args, "--repeat", out var value))
    {
        return 1;
    }

    return int.TryParse(value, out var parsed) ? parsed : -1;
}

static bool TryGetOptionValue(string[] args, string option, out string? value)
{
    for (var i = 0; i < args.Length - 1; i++)
    {
        if (args[i].Equals(option, StringComparison.OrdinalIgnoreCase))
        {
            value = args[i + 1];
            return true;
        }
    }

    value = null;
    return false;
}

static void PrintAvailableVibrations()
{
    Console.WriteLine("Available vibration modes:");
    foreach (var mode in StringFactory.ListAvailableVibrations())
    {
        Console.WriteLine($" - {mode}");
    }

    Console.WriteLine();
    Console.WriteLine("Usage:");
    Console.WriteLine("  dotnet run --project DevStringTheory/DevStringTheory.App -- --list");
    Console.WriteLine("  dotnet run --project DevStringTheory/DevStringTheory.App -- Photon --explain");
    Console.WriteLine("  dotnet run --project DevStringTheory/DevStringTheory.App -- Electron --noise --repeat 5");
    Console.WriteLine("  dotnet run --project DevStringTheory/DevStringTheory.App -- --scenario beginner-lesson");
}

static void PrintTimeline()
{
    Console.WriteLine("Historical timeline (conceptual, condensed):");
    foreach (var milestone in Timeline.HistoricalMilestones)
    {
        Console.WriteLine($" - [{milestone.Era}] {milestone.Event}: {milestone.WhyItMatters}");
    }
}

static void PrintHelp()
{
    Console.WriteLine("Dev String Theory Explorer options:");
    Console.WriteLine("  --list                Show all available vibration modes");
    Console.WriteLine("  --random              Randomly choose a vibration mode");
    Console.WriteLine("  --timeline            Print major historical milestones");
    Console.WriteLine("  --noise               Enable conceptual uncertainty for repeated observations");
    Console.WriteLine("  --repeat <count>      Number of observations (default: 1)");
    Console.WriteLine("  --scenario <file>     Run a scripted lesson from JSON");
    Console.WriteLine("  --explain             Print developer + physics explanation for the selected mode");
    Console.WriteLine("  --help, -h            Show this help text");
    Console.WriteLine();
    Console.WriteLine("You may also pass a mode directly, e.g. 'Electron' or 'Photon'.");
}
