using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Model
{
    public class EmployeeModel
    {
        public int EmployeeId { get; set; }
        [Required]
        [StringLength(100)]
        public string EmployeeName { get; set; }
        [Required]
        [StringLength(100)]
        public string ContactNo { get; set; }
        [Required]
        [StringLength(100)]
        [EmailAddress]
        public string EmailId { get; set; }
        public string DepartmentId { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        [Required]
        public int Gender { get; set; }
        [Required]
        public string Role { get; set; }
    }
}
