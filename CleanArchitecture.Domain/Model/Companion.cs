namespace CleanArchitecture.Domain.Model;

public class Companion
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string WhoPlayed { get; set; }
    public List<EpisodeCompanion> EpisodeCompanions { get; set; }
}