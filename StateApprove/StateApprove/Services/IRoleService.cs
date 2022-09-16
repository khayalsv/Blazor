using StateApprove.Data;

namespace StateApprove.Services
{
    public interface IRoleService
    {
        void CreateRole(Role role);
        void DeleteRole(Role role);
        IEnumerable<Role> GetRoles();
        void UpdateRole(Role role);
    }
}