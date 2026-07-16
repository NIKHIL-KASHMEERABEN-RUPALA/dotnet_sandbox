using GrievanceManagementSystem.ViewModels;

namespace GrievanceManagementSystem.Services
{
    public class DepartmentService : IDepartmentService
    {
        private static List<DepartmentViewModel> departments =
            new List<DepartmentViewModel>()
            {
                new DepartmentViewModel
                {
                    DepartmentId = 1,
                    DepartmentName = "IT",
                    Description = "Information Technology",
                    IsActive = true
                },
                new DepartmentViewModel
                {
                    DepartmentId = 2,
                    DepartmentName = "HR",
                    Description = "Human Resource",
                    IsActive = true
                }
            };

        public List<DepartmentViewModel> GetAllDepartments()
        {
            return departments;
        }

        public DepartmentViewModel GetDepartmentById(int id)
        {
            return departments.FirstOrDefault(x =>
                x.DepartmentId == id);
        }

        public void AddDepartment(DepartmentViewModel department)
        {
            department.DepartmentId =
                departments.Max(x => x.DepartmentId) + 1;

            departments.Add(department);
        }

        public void UpdateDepartment(
            DepartmentViewModel department)
        {
            var existing =
                departments.FirstOrDefault(x =>
                    x.DepartmentId == department.DepartmentId);

            if (existing != null)
            {
                existing.DepartmentName =
                    department.DepartmentName;

                existing.Description =
                    department.Description;

                existing.IsActive =
                    department.IsActive;
            }
        }

        public void DeleteDepartment(int id)
        {
            var department =
                departments.FirstOrDefault(x =>
                    x.DepartmentId == id);

            if (department != null)
            {
                departments.Remove(department);
            }
        }
    }
}