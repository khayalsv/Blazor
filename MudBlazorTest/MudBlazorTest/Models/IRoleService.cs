namespace MudBlazorTest.Models
{
    public interface IRoleService
    {
        void CreateRole(Role role);
        void DeleteRole(Role role);
        IEnumerable<Role> GetRoles();
        void UpdateRole(Role role);
    }
}