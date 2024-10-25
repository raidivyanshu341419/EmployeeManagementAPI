using EmployeeManagement.DbModel;
using EmployeeManagement.Helper;
using EmployeeManagement.Model;

namespace EmployeeManagement.Services.Interface
{
    public interface IEmployeeMgnt
    {
       
        Task<ApiResponse> AddNewParentDepartment(ParentModel parent);
        Task<ApiResponse> AddChildDepartment(ChildModel child);
        Task<List<ParentModel>> GetParentDepartment();
        Task<List<ChildModel>> GetAllChildDepartment();
        Task<List<ChildDepartment>> GetChildDepartmentByParentId(int id);

        Task<List<EmployeeModel>> GetAllEmployee();

        Task<EmployeeModel> GetEmployeeById(int id);
        Task<ApiResponse> AddEmployee(EmployeeModel employee);

        Task<ApiResponse> UpdateEmployee(EmployeeModel employee);
        Task<ApiResponse> DeleteEmployee(int id);

    }
}
