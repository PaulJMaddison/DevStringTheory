using DevStringTheory.App.Fundamental;

namespace DevStringTheory.App.Vibrations
{
    sealed class Gluon : StringBase
    {
        public override string Name => "Gluon";
        public override string Analogy => "Infrastructure glue code that keeps tightly-coupled modules bound together.";
        public override string RealWorldNote => "Gluons are the strong-force carriers that bind quarks.";

        public override void Vibrate() => Console.WriteLine("Vibrating as a Gluon!");
    }
}
