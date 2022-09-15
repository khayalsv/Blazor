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
            var roleCount = _dbContext.Roles.Count();

            role.Name = "User";
            role.RoleCount = roleCount+1;


            _dbContext.Roles.Add(role);


            _roles.Add(role);

            _dbContext.SaveChanges();

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
                _dbContext.Roles.Remove(target);

            }

            _dbContext.SaveChanges();

        }
    }
}
