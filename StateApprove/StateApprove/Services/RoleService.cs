using MudBlazor;
using StateApprove.Data;
using Telerik.DataSource.Extensions;
using static StateApprove.Pages.GridTest;

namespace StateApprove.Services
{
    public class RoleService : IRoleService
    {
        private readonly MyContext _dbContext;

        private List<Role>? _roles;

        public RoleService(MyContext dbContext)
        {
            _dbContext = dbContext;

        }

        public IEnumerable<Role> GetRoles()
        {
            return GetRolesInternal();
        }

        private IEnumerable<Role> GetRolesInternal()
        {
            if (_roles == null)
            {
                _roles = _dbContext.Roles.ToList();
            }

            return _roles;
        }


        public void CreateRole(Role role)
        {
            role.Name = "User";

            role.Sequence = _roles.Max(model => model.Sequence) + 1;




            _dbContext.Roles.Add(role);


            _roles?.Add(role);

            _dbContext.SaveChanges();

        }


        public void UpdateRole(Role role)
        {
            var target = _roles?.FirstOrDefault(p => p.Id == role.Id);
            if (target != null)
            {
                target.Name = role.Name;

            }

            _dbContext.SaveChanges();
        }


        public void DeleteRole(Role role)
        {
            var target = _roles?.FirstOrDefault(p => p.Id == role.Id);
            if (target != null)
            {
                _roles?.Remove(target);
                _dbContext.Roles.Remove(target);

                _dbContext.SaveChanges();

                int a = 1;
                foreach (var item in _dbContext.Roles.ToList())
                {
                    item.Sequence = a;
                    a++;

                }

            }

            _dbContext.SaveChanges();

        }

        public void Commit()
        {
            _dbContext.SaveChangesAsync();
        }
    }
}
