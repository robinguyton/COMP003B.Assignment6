using System.ComponentModel.DataAnnotations;

namespace COMP003B.Assignment6.Models
{
    public class Movies

    {
        [Key]public int MovieID { get; set; }

        public int ActorID { get; set; }

        [Required]
        public required string Name { get; set; }


        public virtual ICollection<Movies>? Movie { get; set; }

    }
}
