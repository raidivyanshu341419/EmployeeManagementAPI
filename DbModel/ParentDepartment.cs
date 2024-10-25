namespace EmployeeManagement.DbModel
{
    public class ParentDepartment
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentLogo { get; set; }
        public ICollection<ChildDepartment> ChildDepartments { get; set; }  
    }
}
