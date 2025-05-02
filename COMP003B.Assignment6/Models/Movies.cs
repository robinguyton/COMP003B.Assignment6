using System.ComponentModel.DataAnnotations;

namespace COMP003B.Assignment6.Models
{
    public class Movies

    {
        public int Id { get; set; }
        public int MovieID { get; set; }

        [Required]
        public required string Name { get; set; }


        public virtual ICollection<Movies>? Movie { get; set; }

    }
}
