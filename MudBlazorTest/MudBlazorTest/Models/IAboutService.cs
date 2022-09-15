namespace MudBlazorTest.Models
{
    public interface IAboutService
    {
        void CreateAbout(About about);
        void DeleteAbout(About about);
        IEnumerable<About> GetAbouts();
        void UpdateAbout(About about);
    }
}