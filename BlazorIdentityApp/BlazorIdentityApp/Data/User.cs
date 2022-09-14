using System.ComponentModel.DataAnnotations;

namespace BlazorIdentityApp.Data
{
    public class User
    {
        [EmailAddress]
        [Required]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string UserRole { get; set; } = string.Empty;
    }
}
