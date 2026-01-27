using DevStringTheory.App.Fundamental;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevStringTheory.App.Vibrations
{
    sealed class Electron : StringBase
    {
        public override void Vibrate() => Console.WriteLine("Vibrating as an Electron!");
    }
}
