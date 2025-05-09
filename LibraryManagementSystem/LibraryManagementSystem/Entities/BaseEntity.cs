using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.API.Entities
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
