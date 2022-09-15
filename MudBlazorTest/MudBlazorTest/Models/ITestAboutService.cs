namespace MudBlazorTest.Models
{
    public interface ITestAboutService
    {
        void CreateAbout(AboutDto about);
        void DeleteAbout(AboutDto about);
        IEnumerable<AboutDto> GetAbouts();
        void UpdateAbout(AboutDto about);
    }
}