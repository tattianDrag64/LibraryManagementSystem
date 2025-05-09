using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagementSystem.API.Entities
{
    public class User :BaseEntity
    {
        [Key]
        public int id { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string  Username { get; set; }
        public string PasswordHash { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string PhoneNumber { get; set; } = string.Empty;

        [NotMapped]
        [Required]
        [MaxLength(20)]
        public string Role { get; set; } 

        [Required]
        public DateTime RegisteredAt { get; set; }
    }
}
