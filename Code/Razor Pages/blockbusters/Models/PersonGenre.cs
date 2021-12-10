using System.ComponentModel.DataAnnotations;

namespace blockbusters.Models
{
    public class PersonGenre
    {
        [Key]
        public int PersonGenreID { get; set; }

        public int PersonID { get; set; }

        public int GenreID { get; set; }

        // NAVIGATION PROPERTIES
        public Genre Genre { get; set; }


        public virtual Person Person { get; set; }
    }
}
