namespace MudBlazorTest.Models
{
    public interface IRoleService
    {
        void CreateRole(Role product);
        void DeleteRole(Role product);
        IEnumerable<Role> GetRoles();
        void UpdateRole(Role product);
    }
}