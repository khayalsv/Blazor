using Microsoft.EntityFrameworkCore;
using MudBlazor;
using StateApprove.Data;
using Telerik.DataSource.Extensions;


namespace StateApprove.Services
{
    public class BaseCompanyService
    {
        private readonly MyContext _dbContext;

        private List<BaseCompany>? _companies;

        public BaseCompanyService(MyContext dbContext)
        {
            _dbContext = dbContext;

        }

        public async Task<BaseCompany> GetByIdAsync(int id)
        {
            var baseCompany = await _dbContext.BaseCompanies.FindAsync(id);
            return baseCompany;

        }

        public IEnumerable<BaseCompany> GetBaseCompanys()
        {
            return GetBaseCompanysInternal();
        }

        private IEnumerable<BaseCompany> GetBaseCompanysInternal()
        {
            if (_companies == null)
            {
                _companies = _dbContext.BaseCompanies.ToList();
            }

            return _companies;
        }


        public void CreateBaseCompany(BaseCompany baseCompany)
        {
            baseCompany.Name = "BaseCompany";

            _dbContext.BaseCompanies.Add(baseCompany);


            _companies?.Add(baseCompany);

            _dbContext.SaveChanges();

        }


        public void UpdateBaseCompany(BaseCompany baseCompany)
        {
            var target = _companies?.FirstOrDefault(p => p.Id == baseCompany.Id);
            if (target != null)
            {
                target.Name = baseCompany.Name;

            }

            _dbContext.SaveChanges();
        }


        public void DeleteBaseCompany(BaseCompany baseCompany)
        {
            var target = _companies?.FirstOrDefault(p => p.Id == baseCompany.Id);
            if (target != null)
            {
                _companies?.Remove(target);
                _dbContext.BaseCompanies.Remove(target);

            }

            _dbContext.SaveChanges();

        }

        public void Commit()
        {
            _dbContext.SaveChangesAsync();
        }
    }
}
