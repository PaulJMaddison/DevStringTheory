using DevStringTheory.App.Fundamental;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DevStringTheory.App.Universe
{
    static class StringFactory
    {
        public static StringBase CreateVibration(string typeName)
        {
            Assembly asm = Assembly.GetExecutingAssembly();

            Type? type = asm.GetTypes()
                .FirstOrDefault(t =>
                    typeof(StringBase).IsAssignableFrom(t) &&
                    !t.IsAbstract &&
                    string.Equals(t.Name, typeName, StringComparison.Ordinal));

            if (type != null)
                return (StringBase)Activator.CreateInstance(type)!;

            throw new ArgumentException($"Invalid string vibration type: '{typeName}'");
        }
    }
}
