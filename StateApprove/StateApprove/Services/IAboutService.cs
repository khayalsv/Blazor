using StateApprove.Data;

namespace StateApprove.Services
{
    public interface IAboutService
    {
        void CreateAbout(About about);
        void DeleteAbout(About about);
        IEnumerable<About> GetAbouts();
        void UpdateAbout(About about);
    }
}