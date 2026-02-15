using System.Text.Json;

namespace DevStringTheory.App.Universe
{
    public sealed class UniverseScenario
    {
        public string Title { get; set; } = "Untitled Scenario";
        public string Introduction { get; set; } = string.Empty;
        public List<ScenarioStep> Steps { get; set; } = [];
    }

    public sealed class ScenarioStep
    {
        public string Label { get; set; } = string.Empty;
        public string? Mode { get; set; }
        public bool Explain { get; set; }
        public bool Noise { get; set; }
        public int Repeat { get; set; } = 1;
        public string? Commentary { get; set; }
    }

    public static class ScenarioLoader
    {
        public static UniverseScenario Load(string scenarioArgument)
        {
            var pathCandidates = new[]
            {
                scenarioArgument,
                Path.Combine("Scenarios", scenarioArgument),
                Path.Combine("Scenarios", $"{scenarioArgument}.json"),
                Path.Combine(AppContext.BaseDirectory, "Scenarios", scenarioArgument),
                Path.Combine(AppContext.BaseDirectory, "Scenarios", $"{scenarioArgument}.json")
            };

            var file = pathCandidates.FirstOrDefault(File.Exists)
                ?? throw new FileNotFoundException($"Scenario file not found for '{scenarioArgument}'.");

            var json = File.ReadAllText(file);
            var scenario = JsonSerializer.Deserialize<UniverseScenario>(json, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

            return scenario ?? throw new InvalidDataException($"Scenario '{file}' could not be parsed.");
        }
    }
}
