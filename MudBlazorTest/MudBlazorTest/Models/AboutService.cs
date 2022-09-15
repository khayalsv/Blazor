using Microsoft.EntityFrameworkCore;
using MudBlazorTest.Data;
using Telerik.Blazor.Resources;

namespace MudBlazorTest.Models
{
    public class AboutService : IAboutService
    {
        private readonly MyContext _dbContext;

        private List<About> _abouts;

        private List<CreateAboutDto> _products;

        public AboutService(MyContext dbContext)
        {
            _dbContext = dbContext;

        }

        public IEnumerable<CreateAboutDto> GetAbouts()
        {
            return GetProductsInternal();
        }


        private IEnumerable<CreateAboutDto> GetProductsInternal()
        {
            if (_products == null)
            {
                // downloading the data before selecting fix a problem with closed db connection in sqlite.
                // The problem may be related to: https://github.com/dotnet/efcore/issues/24015
                _products = _dbContext.Abouts.Include("Role").ToList().Select(CreateAboutDto.AboutFunc).ToList();
            }

            return _products;
        }



        public void UpdateAbout(CreateAboutDto product)
        {
          
            var target = _abouts.FirstOrDefault(p => p.Id == product.AboutId);
            if (target != null)
            {
                target.Name = product.Name;
                target.Amount = product.Amount;
                target.AboutCount = product.AboutCount;
                target.RoleId = product.RoleId;
               
               
            }

            _dbContext.SaveChanges();
        }

        //private IEnumerable<About> GetAboutsInternal()
        //{
        //    if (_abouts == null)
        //    {

        //        _abouts = _dbContext.Abouts.Include(x => x.Role).ToList();
        //    }

        //    return _abouts;
        //}


        //private IEnumerable<About> GetAboutsInternal()
        //{
        //    if (_abouts == null)
        //    {
        //        _abouts = _dbContext.Abouts.ToList();
        //    }

        //    return _abouts;
        //}


        //public void CreateAbout(CreateAboutDto request)
        //{

        //    var role = _dbContext.Roles.Find(request.RoleId);
        //    if (role == null)
        //    {
        //        throw new InvalidOperationException("role null.");
        //    }

        //    var newAbout = new About
        //    {
        //        Name = request.Name,
        //        AboutCount = request.AboutCount + 1,
        //        Amount = request.Amount,
        //        Role = role

        //    };


        //    _dbContext.Abouts.Add(newAbout);

        //    _abouts.Add(newAbout);

        //    _dbContext.SaveChanges();

        //}




        public void CreateAbout(CreateAboutDto product)
        {
            if (!_products.Any())
            {
                product.AboutId = 1;
            }
            else
            {
                product.AboutId = _products.Max(p => p.AboutId) + 1;
            }

            _products.Insert(0, product);
        }


        //public void UpdateAbout(About about)
        //{

        //    var target = _abouts.FirstOrDefault(p => p.Id == about.Id);
        //    if (target != null)
        //    {
        //        target.Name = about.Name;
        //    }

        //    _dbContext.SaveChanges();
        //}


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
