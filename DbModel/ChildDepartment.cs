namespace EmployeeManagement.DbModel
{
    public class ChildDepartment
    {
        public int ChildDepartmentId { get; set; }
        public int ParentDepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public ParentDepartment ParentDepartment { get; set; }
    }
}
