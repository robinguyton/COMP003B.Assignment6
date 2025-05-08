using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using Microsoft.EntityFrameworkCore;

namespace COMP003B.Assignment6.Models
{
    public class Director

    {
        [Key] public int DirectorID { get; set; }

        public int Name { get; set; }

        public int Movie { get; set; }


        }
    }
