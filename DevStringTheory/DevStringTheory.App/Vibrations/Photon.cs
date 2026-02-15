using DevStringTheory.App.Fundamental;

namespace DevStringTheory.App.Vibrations
{
    public sealed class Photon : StringBase
    {
        public override string Name => "Photon";
        public override string Analogy => "At runtime, the same factory can load Photon instead, showing how one abstraction dispatches a different derived behavior.";
        public override string RealWorldNote => "Photons are force carriers for electromagnetism and are massless.";

        public override void Vibrate() => Console.WriteLine("Vibrating as a Photon!");
    }
}
