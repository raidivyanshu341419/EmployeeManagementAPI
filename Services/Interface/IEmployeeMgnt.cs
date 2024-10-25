using EmployeeManagement.DbModel;
using EmployeeManagement.Helper;
using EmployeeManagement.Model;

namespace EmployeeManagement.Services.Interface
{
    public interface IEmployeeMgnt
    {

        Task<AddNewParentDepartmentResponseModel> AddNewParentDepartment(ParentModel parent);
        Task<ApiResponse> AddChildDepartment(ChildModel child);
        Task<GetAllparentDepartment> GetParentDepartment();
        Task<List<ChildModel>> GetAllChildDepartment();
        Task<List<ChildDepartment>> GetChildDepartmentByParentId(int id);

        Task<List<GetEmployeeModel>> GetAllEmployee();

        Task<GetEmployeeModel> GetEmployeeById(int id);
        Task<ApiResponse> AddEmployee(EmployeeModel employee);

        Task<ApiResponse> UpdateEmployee(EmployeeModel employee);
        Task<ApiResponse> DeleteEmployee(int id);

    }
}
