using DevStringTheory.App.Fundamental;
using System.Reflection;

namespace DevStringTheory.App.Universe
{
    static class StringFactory
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
    }
}
