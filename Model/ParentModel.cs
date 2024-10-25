using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Model
{
    public class ParentModel
    {
        public int DepartmentId { get; set; }
        [Required]
        [StringLength(100)]
        public string DepartmentName { get; set; }
        [Required]
        [StringLength(100)]
        public string DepartmentLogo { get; set; }

    }

}
