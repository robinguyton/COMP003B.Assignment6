using Microsoft.EntityFrameworkCore;
using COMP003B.Assignment6.Models;


namespace COMP003B.Assignment6.Data
{
    public class WebDevAcademyContext : DbContext
    {
        public WebDevAcademyContext(DbContextOptions<WebDevAcademyContext> options) : base(options)
        {
        }

        public DbSet<Actors> Actors { get; set; }
        public DbSet<Directors> Directors { get; set; }
        public DbSet<Movies> Movies { get; set; }

        public  DbSet  <Actors> ActorID { get; set; }



    }
}
