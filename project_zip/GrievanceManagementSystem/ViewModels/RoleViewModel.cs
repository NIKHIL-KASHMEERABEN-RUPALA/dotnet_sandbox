using System.ComponentModel.DataAnnotations;

namespace GrievanceManagementSystem.ViewModels
{
    public class RoleViewModel
    {
        public int RoleId { get; set; }

        [Required(ErrorMessage = "Role Name is required")]
        [StringLength(50)]
        public string RoleName { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        public bool IsActive { get; set; }
    }
}