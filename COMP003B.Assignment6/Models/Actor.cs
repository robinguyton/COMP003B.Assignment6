using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace COMP003B.Assignment6.Models
{
    public class Actor
    {
        [Key]
        public int ActorID { get; set; }

        public int Name { get; set; }

        public int Director { get; set; }

        public string Movie { get; set; }




        public virtual ICollection<Movie>? Movies { get; set; }
    }
}
