using System.ComponentModel.DataAnnotations;

namespace COMP003B.Assignment6.Models
{
    public class Movie

    {
        [Key]public int MovieID{ get; set; }

        public int Actor { get; set; }

        public int Directors { get; set; }

        [Required]
        public required string Name { get; set; }




        public virtual ICollection<Movie>? Movies { get; set; }

    }
}
