namespace LibraryManagementSystem.API.Entities
{
    public class Author : BaseEntity
    {
        public string Name { get; set; }
        public string Biography { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string ImageUrl { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
