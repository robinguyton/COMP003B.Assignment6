using System.ComponentModel.DataAnnotations;

namespace COMP003B.Assignment6.Models
{
    public class Movies
    {
        public int ActorId { get; set; }

        [Required]
        public required string Name { get; set; }


        public virtual ICollection<Actor>? Actors { get; set; }

    }
}
