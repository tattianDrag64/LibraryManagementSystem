﻿namespace LibraryManagementSystem.API.Entities
{
    public class Genre : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Book> Books { get; set; } 
    }
}
