namespace DevStringTheory.App.Universe
{
    public sealed record Milestone(string Era, string Event, string WhyItMatters);

    public static class Timeline
    {
        public static IReadOnlyList<Milestone> HistoricalMilestones { get; } =
        [
            new("1897", "Electron identified", "Showed that atoms contain smaller constituents."),
            new("1932", "Neutron discovered", "Completed the early proton-neutron-electron particle picture."),
            new("1964", "Quark model proposed", "Suggested hadrons are built from more fundamental components."),
            new("1970s", "Standard Model consolidated", "Unified particle interactions with quantum field theory."),
            new("1984", "First superstring revolution", "String theory gained consistency tools and renewed interest."),
            new("1995", "Second superstring revolution", "Dualities and M-theory linked previously separate models."),
            new("Modern era", "Landscape + phenomenology research", "Ongoing work connects string-inspired ideas to observable physics.")
        ];
    }
}
