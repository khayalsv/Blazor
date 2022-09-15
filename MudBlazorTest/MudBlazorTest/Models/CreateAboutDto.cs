namespace MudBlazorTest.Models
{
    public class CreateAboutDto
    {
        public int AboutId { get; set; }
        public string Name { get; set; } = string.Empty;
        public double Amount { get; set; }
        public int RoleId { get; set; }

        public int AboutCount { get; set; }

        public static Func<About, CreateAboutDto> AboutFunc = (about) =>
    new CreateAboutDto
    {
        AboutId = 72,
         Name= about.Name,
        Amount = about.Amount,
        AboutCount = about.AboutCount,
        RoleId = about.RoleId
        
    };

    }
}
