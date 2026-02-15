using DevStringTheory.App.Universe;

var failures = new List<string>();

void Assert(bool condition, string message)
{
    if (!condition)
    {
        failures.Add(message);
    }
}

var modes = StringFactory.ListAvailableVibrations();
Assert(modes.Contains("Electron"), "Expected runtime discovery to include Electron.");
Assert(modes.Contains("Photon"), "Expected runtime discovery to include Photon.");
Assert(modes.Contains("Quark"), "Expected runtime discovery to include Quark.");

try
{
    StringFactory.CreateVibration("BogusMode");
    failures.Add("Expected unknown vibration to throw ArgumentException.");
}
catch (ArgumentException ex)
{
    Assert(ex.Message.Contains("Invalid string vibration type: 'BogusMode'"), "Error message should include unknown mode name.");
    Assert(ex.Message.Contains("Available options:"), "Error message should include available options.");
}

if (failures.Count > 0)
{
    Console.Error.WriteLine("Test failures:");
    foreach (var failure in failures)
    {
        Console.Error.WriteLine($" - {failure}");
    }

    return 1;
}

Console.WriteLine("All DevStringTheory unit checks passed.");
return 0;
