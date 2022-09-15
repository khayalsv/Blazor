namespace MudBlazorTest.Models
{
    public interface IAboutService
    {
        void CreateAbout(CreateAboutDto request);
        void DeleteAbout(About about);
        IEnumerable<CreateAboutDto> GetAbouts();
        void UpdateAbout(CreateAboutDto about);
    }
}