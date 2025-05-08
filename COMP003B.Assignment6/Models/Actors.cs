using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace COMP003B.Assignment6.Models
{
    public class Actors
    {
        [Key]
        public int ActorID { get; set; }

        public int MovieID { get; set; }
        public int DirectorID { get; set; }
        public required string Name { get; set; }

        public virtual Actors? Actor { get; set; }
        public virtual Directors? Director { get; set; }

        public virtual ICollection<Movies>? Movies { get; set; }
    }
}
