using GrievanceManagementSystem.ViewModels;

namespace GrievanceManagementSystem.Services
{
    public interface IRoleService
    {
        List<RoleViewModel> GetAllRoles();

        RoleViewModel GetRoleById(int id);

        void AddRole(RoleViewModel role);

        void UpdateRole(RoleViewModel role);

        void DeleteRole(int id);
    }
}