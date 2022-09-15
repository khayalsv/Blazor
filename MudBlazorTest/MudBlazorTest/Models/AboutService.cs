using Microsoft.EntityFrameworkCore;
using MudBlazorTest.Data;
using Telerik.Blazor.Resources;

namespace MudBlazorTest.Models
{
    public class AboutService : IAboutService
    {
        private readonly MyContext _dbContext;

        private List<About> _abouts;

        public AboutService(MyContext dbContext)
        {
            _dbContext = dbContext;

        }

        public IEnumerable<About> GetAbouts()
        {
            return GetAboutsInternal();
        }

        private IEnumerable<About> GetAboutsInternal()
        {
            if (_abouts == null)
            {
                //_abouts = _dbContext.Abouts.ToList();
                _abouts = _dbContext.Abouts.Include(x => x.Role).ToList();
            }

            return _abouts;
        }


        public void CreateAbout(About about)
        {
            var aboutCount = _dbContext.Abouts.Count();


            about.RoleId = 224;
            about.Name = "User";
            about.AboutCount = aboutCount + 1;


            _dbContext.Abouts.Add(about);


            _abouts.Add(about);

            _dbContext.SaveChanges();

        }


        public void UpdateAbout(About about)
        {
            var target = _abouts.FirstOrDefault(p => p.Id == about.Id);
            if (target != null)
            {
                target.Name = about.Name;
                target.AboutCount = about.AboutCount;
                target.Amount = about.Amount;
                target.RoleId = about.RoleId;
            }

            _dbContext.SaveChanges();
        }


        public void DeleteAbout(About about)
        {
            var target = _abouts.FirstOrDefault(p => p.Id == about.Id);
            if (target != null)
            {
                _abouts.Remove(target);
                _dbContext.Abouts.Remove(target);

            }

            _dbContext.SaveChanges();

        }
    }

}
