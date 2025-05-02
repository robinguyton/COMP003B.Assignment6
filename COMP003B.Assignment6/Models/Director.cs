using System.ComponentModel.DataAnnotations;

namespace COMP003B.Assignment6.Models
{
    public class Director

    {
        public int Id { get; set; } 
        public int DirectorID { get; set; }

             [Required]
            public string Name { get; set; }

            public virtual ICollection<Director>? Directors { get; set; }
        }
    }
