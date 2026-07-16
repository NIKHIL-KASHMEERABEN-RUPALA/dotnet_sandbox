using System.ComponentModel.DataAnnotations;

namespace GrievanceManagementSystem.Models
{
    public class GMSRole
    {
        public int RoleId { get; set; }

        [Required]
        [StringLength(50)]
        public string RoleName { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        public bool IsActive { get; set; }
    }
}