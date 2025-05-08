using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using Microsoft.EntityFrameworkCore;

namespace COMP003B.Assignment6.Models
{
    public class Directors

    {
        [Key] public int DirectorID { get; set; }

        public int MovieID { get; set; }
        public int ActorID { get; set; }




             [Required]
            public string Name { get; set; }

        }
    }
