namespace DoctorWho.Db.Model
{
    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime FirstEpisodeDate { get; set; }
        public DateTime LastEpisodeDate { get; set; }
        public List<Episode> Episodes { get; set; }
    }
}
