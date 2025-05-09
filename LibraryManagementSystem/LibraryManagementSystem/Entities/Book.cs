namespace LibraryManagementSystem.API.Entities
{
    public class Book : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ISBN { get; set; }
        public int BookCode { get; set; }
        public DateTime PublishedDate { get; set; }
        public int PageCount { get; set; }
        public string Language { get; set; }
        public string CoverImageUrl { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public int GengreId { get; set; }
        public Genre Genre { get; set; }
       // public ICollection<User> BorrowedUsers { get; set; } = new List<User>();
    }
}
