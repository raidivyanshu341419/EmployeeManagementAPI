using EmployeeManagement.DbModel;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Model
{
    public class ChildModel
    {
        public int ChildDepartmentId { get; set; }
       
        public int ParentDepartmentId { get; set; }
        [Required]
        [StringLength(100)]
        public string DepartmentName { get; set; }
       
    }
}
