using System.ComponentModel.DataAnnotations;

namespace GrievanceManagementSystem.Models
{
    public class GMSDepartment
    {
        public int DepartmentId { get; set; }

        [Required]
        [StringLength(100)]
        public string DepartmentName { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        public bool IsActive { get; set; }
    }
}