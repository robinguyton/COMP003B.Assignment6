namespace COMP003B.Assignment6.Models
{
    public class Actors
    {
        public int Id { get; set; }
        public int ActorId { get; set; }
        public int DirectorId { get; set; }
        public virtual Actor? Actor { get; set; }
        public virtual Director? Director { get; set; }
    }
}
