using DevStringTheory.App.Fundamental;

namespace DevStringTheory.App.Vibrations
{
    public sealed class Electron : StringBase
    {
        public override string Name => "Electron";
        public override string Analogy => "At runtime, the factory resolves Electron by name and returns it as StringBase so polymorphism can execute the concrete behavior.";
        public override string RealWorldNote => "Electrons are leptons and carry negative electric charge.";

        public override void Vibrate() => Console.WriteLine("Vibrating as an Electron!");
    }
}
