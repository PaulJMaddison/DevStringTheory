using DevStringTheory.App.Fundamental;
using System.Reflection;

namespace DevStringTheory.App.Universe
{
    public static class StringFactory
    {
        private static readonly IReadOnlyDictionary<string, Type> VibrationTypes =
            Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(t => typeof(StringBase).IsAssignableFrom(t) && !t.IsAbstract)
                .ToDictionary(t => t.Name, t => t, StringComparer.OrdinalIgnoreCase);

        public static IReadOnlyList<string> ListAvailableVibrations() =>
            VibrationTypes.Keys.OrderBy(x => x, StringComparer.OrdinalIgnoreCase).ToList();

        public static StringBase CreateVibration(string typeName)
        {
            if (VibrationTypes.TryGetValue(typeName, out var type))
            {
                return (StringBase)Activator.CreateInstance(type)!;
            }

            var options = string.Join(", ", ListAvailableVibrations());
            throw new ArgumentException($"Invalid string vibration type: '{typeName}'. Available options: {options}");
        }

        public static StringBase CreateRandomVibration(Random random)
        {
            var options = ListAvailableVibrations();
            var choice = options[random.Next(options.Count)];
            return CreateVibration(choice);
        }

        public static StringBase ObserveWithNoise(string preferredTypeName, Random random)
        {
            var preferred = CreateVibration(preferredTypeName);
            if (random.NextDouble() <= 0.7)
            {
                return preferred;
            }

            var options = ListAvailableVibrations()
                .Where(v => !v.Equals(preferredTypeName, StringComparison.OrdinalIgnoreCase))
                .ToList();

            if (options.Count == 0)
            {
                return preferred;
            }

            return CreateVibration(options[random.Next(options.Count)]);
        }
    }
}
