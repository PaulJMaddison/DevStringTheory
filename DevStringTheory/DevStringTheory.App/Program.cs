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

var explainMode = args.Contains("--explain", StringComparer.OrdinalIgnoreCase);
var selectedMode = args.FirstOrDefault(arg => !arg.StartsWith("--", StringComparison.Ordinal));

StringBase particle;

try
{
    if (args.Contains("--random", StringComparer.OrdinalIgnoreCase))
    {
        particle = StringFactory.CreateRandomVibration(Random.Shared);
        Console.WriteLine("Random vibration mode selected at runtime.");
    }
    else if (!string.IsNullOrWhiteSpace(selectedMode))
    {
        particle = StringFactory.CreateVibration(selectedMode);
        Console.WriteLine($"Selected vibration mode: {selectedMode}");
    }
    else
    {
        PrintAvailableVibrations();
        Console.Write("Type a vibration mode to manifest: ");
        var input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("No mode entered. Exiting.");
            return;
        }

        particle = StringFactory.CreateVibration(input.Trim());
        Console.WriteLine($"Selected vibration mode: {input.Trim()}");
    }
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine("Use --list to see valid options.");
    return;
}

Console.WriteLine("Asking the universe to manifest this vibration...");
Console.WriteLine();

particle.Vibrate();

if (explainMode)
{
    Console.WriteLine();
    particle.Explain();
}

Console.WriteLine();
Console.WriteLine("Observation complete.");
Console.WriteLine("Same fundamental string. Different vibration, different particle.");
Console.WriteLine("===================================");

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
    Console.WriteLine("  dotnet run --project DevStringTheory/DevStringTheory.App -- --random --explain");
}

static void PrintHelp()
{
    Console.WriteLine("Dev String Theory Explorer options:");
    Console.WriteLine("  --list      Show all available vibration modes");
    Console.WriteLine("  --random    Randomly choose a vibration mode");
    Console.WriteLine("  --explain   Print developer + physics explanation for the selected mode");
    Console.WriteLine("  --help, -h  Show this help text");
    Console.WriteLine();
    Console.WriteLine("You may also pass a mode directly, e.g. 'Electron' or 'Photon'.");
}
