namespace COMP003B.Assignment6.Models
{
    public class Director
    {
            public int DirectorID { get; set; }

            [Required]
            public string Title { get; set; }

            public virtual ICollection<Director>? Directors { get; set; }
        }
    }
