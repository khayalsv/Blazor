using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;

namespace MudBlazorTest.Models
{
    public class RoleService : IRoleService
    {
        private readonly MyContext _dbContext;

        private List<Role> _roles;

        public RoleService(MyContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Role> GetRoles()
        {
            return GetRolesInternal();
        }


        public void CreateRole(Role role)
        {
            if (!_roles.Any())
            {
                role.Id = 1;
            }
            else
            {
                role.Id = _roles.Max(p => p.Id) + 1;
            }


            _roles.Insert(0, role)

            //_dbContext.SaveChanges();

            //_dbContext.Roles.Add(role);



           
        }


        public void UpdateRole(Role role)
        {
            var target = _roles.FirstOrDefault(p => p.Id == role.Id);
            if (target != null)
            {
                target.Name = role.Name;
            }

            _dbContext.SaveChanges();
        }


        public void DeleteRole(Role role)
        {
            var target = _roles.FirstOrDefault(p => p.Id == role.Id);
            if (target != null)
            {
                _roles.Remove(target);
            }

            _dbContext.Roles.Remove(target);

            _dbContext.SaveChanges();

        }
        private IEnumerable<Role> GetRolesInternal()
        {
            if (_roles == null)
            {

                _roles = _dbContext.Roles.ToList();
            }

            return _roles;
        }
    }
}
