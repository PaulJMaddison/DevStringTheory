using DevStringTheory.App.Fundamental;

namespace DevStringTheory.App.Vibrations
{
    public sealed class Neutrino : StringBase
    {
        public override string Name => "Neutrino";
        public override string Analogy => "Neutrino shows low-interaction behavior chosen at runtime via the same base-type pipeline and factory lookup.";
        public override string RealWorldNote => "Neutrinos interact weakly with matter and are extremely hard to detect.";

        public override void Vibrate() => Console.WriteLine("Vibrating as a Neutrino!");
    }
}
