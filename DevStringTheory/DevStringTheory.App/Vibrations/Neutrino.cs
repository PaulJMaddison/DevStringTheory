using DevStringTheory.App.Fundamental;

namespace DevStringTheory.App.Vibrations
{
    sealed class Neutrino : StringBase
    {
        public override string Name => "Neutrino";
        public override string Analogy => "A background process that passes through most systems without interacting much.";
        public override string RealWorldNote => "Neutrinos interact weakly with matter and are extremely hard to detect.";

        public override void Vibrate() => Console.WriteLine("Vibrating as a Neutrino!");
    }
}
