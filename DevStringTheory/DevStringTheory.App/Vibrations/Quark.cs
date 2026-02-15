using DevStringTheory.App.Fundamental;

namespace DevStringTheory.App.Vibrations
{
    public sealed class Quark : StringBase
    {
        public override string Name => "Quark";
        public override string Analogy => "Quark is another runtime manifestation loaded through reflection and surfaced behind StringBase to keep calling code uniform.";
        public override string RealWorldNote => "Quarks combine to form hadrons such as protons and neutrons.";

        public override void Vibrate() => Console.WriteLine("Vibrating as a Quark!");
    }
}
