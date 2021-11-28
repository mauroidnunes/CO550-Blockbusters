namespace blockbusters.Models
{
    public class PersonGenre
    {
        // FOREIGN KEYS
        public int PersonID { get; set; }
        public Person Person { get; set; }

        public int GenreID { get; set; }
        public Genre Genre { get; set; }
    }
}
