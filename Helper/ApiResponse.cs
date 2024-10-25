using EmployeeManagement.DbModel;
using EmployeeManagement.Model;

namespace EmployeeManagement.Helper
{
    public class ApiResponse
    {
        public int Code { get; set; }
        public string Message { get; set; }
        public string Result { get; set; }

        public String data { get; set; }
    }

    public class AddNewParentDepartmentResponseModel
    {
        public bool status { get; set; }
        public string message { get; set; }
        public ParentDepartment parentDepartment { get; set; }
    }

    public class GetAllparentDepartment
    {
        public bool status { get; set; }
        public string msg { get; set; }
        public List<ParentModel> parentDepartment { get; set; }
    }
}
