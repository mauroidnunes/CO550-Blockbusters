using System.ComponentModel.DataAnnotations;

namespace blockbusters.Models
{
    public class PersonGenre
    {
        [Key]
        public int PersonGenreID { get; set; }

        public int PersonID { get; set; }

        public virtual Genre GenreID { get; set; }

        // NAVIGATION PROPERTIES

        public virtual Person Person { get; set; }
    }
}
