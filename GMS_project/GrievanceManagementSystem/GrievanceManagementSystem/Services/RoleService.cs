using GrievanceManagementSystem.ViewModels;

namespace GrievanceManagementSystem.Services
{
    public class RoleService : IRoleService
    {
        private static List<RoleViewModel> roles =
        new()
        {
            new RoleViewModel
            {
                RoleId = 1,
                RoleName = "Admin",
                Description = "System Administrator",
                IsActive = true
            }
        };

        public List<RoleViewModel> GetAllRoles()
        {
            return roles;
        }

        public RoleViewModel GetRoleById(int id)
        {
            return roles.FirstOrDefault(x => x.RoleId == id);
        }

        public void AddRole(RoleViewModel role)
        {
            role.RoleId = roles.Max(x => x.RoleId) + 1;

            roles.Add(role);
        }

        public void UpdateRole(RoleViewModel role)
        {
            var existing =
                roles.FirstOrDefault(x => x.RoleId == role.RoleId);

            if (existing != null)
            {
                existing.RoleName = role.RoleName;
                existing.Description = role.Description;
                existing.IsActive = role.IsActive;
            }
        }

        public void DeleteRole(int id)
        {
            var role =
                roles.FirstOrDefault(x => x.RoleId == id);

            if (role != null)
            {
                roles.Remove(role);
            }
        }
    }
}