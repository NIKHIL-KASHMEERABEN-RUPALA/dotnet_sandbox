using GrievanceManagementSystem.ViewModels;

namespace GrievanceManagementSystem.Services
{
    public interface IDepartmentService
    {
        List<DepartmentViewModel> GetAllDepartments();

        DepartmentViewModel GetDepartmentById(int id);

        void AddDepartment(DepartmentViewModel department);

        void UpdateDepartment(DepartmentViewModel department);

        void DeleteDepartment(int id);
    }
}