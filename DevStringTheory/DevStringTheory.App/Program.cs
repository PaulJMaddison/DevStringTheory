// See https://aka.ms/new-console-template for more information
using DevStringTheory.App.Fundamental;
using DevStringTheory.App.Universe;

Console.WriteLine("=== Dev String Theory Simulation ===");
Console.WriteLine("One fundamental string. Many possible vibrations.");
Console.WriteLine();

Console.WriteLine("Initializing fundamental string state...");
Console.WriteLine("Determining vibration mode at runtime...");
Console.WriteLine();

// Runtime “vibration determination” (could come from config, input, environment, etc.)
string vibrationType = "Electron"; // try "Photon" or "Quark"

Console.WriteLine($"Selected vibration mode: {vibrationType}");
Console.WriteLine("Asking the universe to manifest this vibration...");
Console.WriteLine();

// The universe picks/loads the correct vibration dynamically at runtime
StringBase particle = StringFactory.CreateVibration(vibrationType);

Console.WriteLine("Vibration manifested. Observing particle behavior...");
Console.WriteLine();

// Observed manifestation of the underlying string
particle.Vibrate();

Console.WriteLine();
Console.WriteLine("Observation complete.");
Console.WriteLine("Same fundamental string. Different vibration, different particle.");
Console.WriteLine("===================================");