using DevStringTheory.App.Fundamental;

namespace DevStringTheory.App.Vibrations
{
    public sealed class Gluon : StringBase
    {
        public override string Name => "Gluon";
        public override string Analogy => "Runtime selection of Gluon demonstrates that different derived types can be instantiated through one reflection-driven factory contract.";
        public override string RealWorldNote => "Gluons are the strong-force carriers that bind quarks.";

        public override void Vibrate() => Console.WriteLine("Vibrating as a Gluon!");
    }
}
