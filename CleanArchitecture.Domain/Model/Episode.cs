namespace DoctorWho.Db.Model
{
    public class Episode
    {
        public int Id { get; set; }
        public int SeriesNumber { get; set; }
        public int EpisodeNumber { get; set; }
        public string Episodetype { get; set; }
        public string Title { get; set; }
        public DateTime EpsodeDate { get; set; }
        public int AuthorId { get; set; }
        public int? DoctorId { get; set; }
        public string Notes { get; set; }
        public Author Author { get; set; }
        public Doctor Doctor { get; set; }
        public List<EpisodeEnemy> EpisodeEnemies { get; set; }
        public List<EpisodeCompanion> EpisodeCompanions { get; set; }
    }
}
