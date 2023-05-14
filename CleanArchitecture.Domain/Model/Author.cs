namespace DoctorWho.Db.Model
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Episode> Episodes { get; set; }
    }
}
