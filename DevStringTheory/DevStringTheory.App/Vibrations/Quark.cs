using DevStringTheory.App.Fundamental;

namespace DevStringTheory.App.Vibrations
{
    sealed class Quark : StringBase
    {
        public override string Name => "Quark";
        public override string Analogy => "A low-level component that rarely exists alone and usually composes bigger structures.";
        public override string RealWorldNote => "Quarks combine to form hadrons such as protons and neutrons.";

        public override void Vibrate() => Console.WriteLine("Vibrating as a Quark!");
    }
}
