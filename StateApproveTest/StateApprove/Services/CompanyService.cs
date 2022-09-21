using Microsoft.EntityFrameworkCore;
using MudBlazor;
using StateApprove.Data;
using Telerik.DataSource.Extensions;


namespace StateApprove.Services
{
    public class CompanyService
    {
        private readonly MyContext _dbContext;

        private List<Company>? _companies;

        public CompanyService(MyContext dbContext)
        {
            _dbContext = dbContext;

        }

        public async Task<Company> GetByIdAsync(int id)
        {
            var company = await _dbContext.Companies.FindAsync(id);
            return company;

        }

        public IEnumerable<Company> GetCompanys()
        {
            return GetCompanysInternal();
        }

        private IEnumerable<Company> GetCompanysInternal()
        {
            if (_companies == null)
            {
                _companies = _dbContext.Companies.ToList();
            }

            return _companies;
        }


        public void CreateCompany(Company company)
        {
            company.Name = "Company";

            _dbContext.Companies.Add(company);


            _companies?.Add(company);

            _dbContext.SaveChanges();

        }


        public void UpdateCompany(Company company)
        {
            var target = _companies?.FirstOrDefault(p => p.Id == company.Id);
            if (target != null)
            {
                target.Name = company.Name;
                target.Description = company.Description;

            }

            _dbContext.SaveChanges();
        }


        public void DeleteCompany(Company company)
        {
            var target = _companies?.FirstOrDefault(p => p.Id == company.Id);
            if (target != null)
            {
                _companies?.Remove(target);
                _dbContext.Companies.Remove(target);

            }

            _dbContext.SaveChanges();

        }

        public void Commit()
        {
            _dbContext.SaveChangesAsync();
        }
    }
}
