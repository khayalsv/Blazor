using Microsoft.EntityFrameworkCore;

namespace MudBlazorTest.Models
{
    public class TestAboutService : ITestAboutService
    {
        private readonly MyContext _dbContext;

        private List<AboutDto> _abouts;

        public TestAboutService(MyContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<AboutDto> GetAbouts()
        {
            return GetAboutsInternal();
        }

        public void CreateAbout(AboutDto about)
        {
            if (!_abouts.Any())
            {
                about.Id = 1;
            }
            else
            {
                about.Id = _abouts.Max(p => p.Id) + 1;
            }

            _abouts.Insert(0, about);
        }

        public void UpdateAbout(AboutDto about)
        {
            var target = _abouts.FirstOrDefault(p => p.Id == about.Id);
            if (target != null)
            {
                target.Name = about.Name;
                target.Amount = about.Amount;
                target.AboutCount = about.AboutCount;
                target.RoleId = about.RoleId;
                target.RoleName = about.RoleName;
            }


            _dbContext.UpdateRange(_abouts);
            
            _dbContext.SaveChanges();
        }

        public void DeleteAbout(AboutDto about)
        {
            var target = _abouts.FirstOrDefault(p => p.Id == about.Id);
            if (target != null)
            {
                _abouts.Remove(target);
            }
        }

        private IEnumerable<AboutDto> GetAboutsInternal()
        {
            if (_abouts == null)
            {
                // downloading the data before selecting fix a problem with closed db connection in sqlite.
                // The problem may be related to: https://github.com/dotnet/efcore/issues/24015
                //_abouts = _dbContext.Abouts.Include("Role").ToList().Select(AboutDto.AboutFunc).ToList();
            }

            return _abouts;
        }
    }
}
