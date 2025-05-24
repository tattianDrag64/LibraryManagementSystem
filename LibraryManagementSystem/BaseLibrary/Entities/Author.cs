using System.ComponentModel.DataAnnotations;

namespace BaseLibrary.Entities
{
    public class Author 
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public required string Name { get; set; }
        [MaxLength(1000)]
        public string? Biography { get; set; }
        public required DateTime DateOfBirth { get; set; }
        public bool IsAlive { get; set; } = true;
        public DateTime? DateOfDeath { get; set; }
        public string? ImageUrl { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
