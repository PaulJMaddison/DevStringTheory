namespace DevStringTheory.App.Fundamental
{
    public abstract class StringBase
    {
        public abstract string Name { get; }
        public abstract string Analogy { get; }
        public abstract string RealWorldNote { get; }

        public abstract void Vibrate();

        public virtual void Explain()
        {
            Console.WriteLine($"Particle: {Name}");
            Console.WriteLine($"Developer analogy: {Analogy}");
            Console.WriteLine($"Physics note: {RealWorldNote}");
        }
    }
}
