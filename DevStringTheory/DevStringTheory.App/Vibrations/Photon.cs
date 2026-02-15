using DevStringTheory.App.Fundamental;

namespace DevStringTheory.App.Vibrations
{
    public sealed class Photon : StringBase
    {
        public override string Name => "Photon";
        public override string Analogy => "A lightweight event message moving information between services.";
        public override string RealWorldNote => "Photons are force carriers for electromagnetism and are massless.";

        public override void Vibrate() => Console.WriteLine("Vibrating as a Photon!");
    }
}
