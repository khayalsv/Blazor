using System.ComponentModel.DataAnnotations;

namespace BlazorIdentityApp.Data
{
    public class Role
    {
        [EmailAddress]
        [Required]
        public string RoleName { get; set; } = string.Empty;

        [Required]
        public string Id { get; set; } = string.Empty;
    }
}
