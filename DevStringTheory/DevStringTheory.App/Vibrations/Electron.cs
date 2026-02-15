using DevStringTheory.App.Fundamental;

namespace DevStringTheory.App.Vibrations
{
    sealed class Electron : StringBase
    {
        public override string Name => "Electron";
        public override string Analogy => "A stable, well-known implementation every app depends on.";
        public override string RealWorldNote => "Electrons are leptons and carry negative electric charge.";

        public override void Vibrate() => Console.WriteLine("Vibrating as an Electron!");
    }
}
