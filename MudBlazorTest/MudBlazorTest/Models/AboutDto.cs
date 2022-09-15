namespace MudBlazorTest.Models
{
    public class AboutDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public double Amount { get; set; }
        public int AboutCount { get; set; }
        public int RoleId { get; set; }
        public string RoleName { get; set; }

        public static Func<About, AboutDto> AboutFunc = (about) =>
            new AboutDto
            {
                Id = about.Id,
                Name = about.Name,
                Amount = about.Amount,
                AboutCount = about.AboutCount,
                RoleId = about.RoleId,
                RoleName = about.Role.Name
            };

    }
}
