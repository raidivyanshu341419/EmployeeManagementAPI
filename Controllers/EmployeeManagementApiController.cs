using EmployeeManagement.Model;
using EmployeeManagement.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeApiController : ControllerBase
    {
        private readonly IEmployeeMgnt _employeeMgnt;

        public EmployeeApiController(IEmployeeMgnt employeeMgnt)
        {
            _employeeMgnt = employeeMgnt;
        }
        [HttpPost("AddNewParentDepartment")]
        public async Task<IActionResult> AddNewParentDepartment([FromBody] ParentModel parent)
        {
            try
            {
                var data = await _employeeMgnt.AddNewParentDepartment(parent);
                return Ok(data);
            }
            catch (Exception ex)
            {

                return StatusCode(500, new { Message = ex.Message });

            }
        }

        [HttpPost("AddNewChildDepartment")]
        public async Task<IActionResult> AddChildDepartment([FromBody] ChildModel child)
        {
            try
            {
                var childDept = await _employeeMgnt.AddChildDepartment(child);
                return StatusCode(childDept.Code, new { Message = childDept.Message });
            }
            catch (Exception ex)
            {

                return StatusCode(500, new { Message = ex.Message });
            }
        }

        [HttpGet]
        [Route("GetAllParentDepartment")]
        public async Task<IActionResult> GetParentDepartment()
        {
            try
            {
                var parentdept = await _employeeMgnt.GetParentDepartment();
                return Ok(parentdept);
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet]
        [Route("GetAllChildDepartment")]
        public async Task<IActionResult> GetAllChildDepartment()
        {
            try
            {
                var childDept = await _employeeMgnt.GetAllChildDepartment();
                return Ok(childDept);

            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet]
        [Route("GetAllEmployee")]
        public async Task<IActionResult> GetAllEmployee()
        {
            try
            {
                var employee = await _employeeMgnt.GetAllEmployee();
                return Ok(employee);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet]
        [Route("ChildDeptById")]
        public async Task<IActionResult> GetChildDepartmentByParentId(int id)
        {
            try
            {
                var childDept = await _employeeMgnt.GetChildDepartmentByParentId(id);
                return Ok(childDept);

            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet]
        [Route("GetEmployeeById")]
        public async Task<IActionResult> GetEmployeeById(int id)
        {
            try
            {
                var employee = await _employeeMgnt.GetEmployeeById(id);
                return Ok(employee);
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }
        }
        [HttpPost("AddNewEmployee")]
        public async Task<IActionResult> AddEmployee([FromBody] EmployeeModel employeeModel)
        {
            try
            {
                var data = await _employeeMgnt.AddEmployee(employeeModel);
                return StatusCode(data.Code, new { Message = data.Message });
            }
            catch (Exception ex)
            {

                return StatusCode(500, new { Message = ex.Message });
            }
        }
        [HttpPut("UpdateEmployee{id}")]
        public async Task<IActionResult> UpdateEmployee([FromBody] EmployeeModel employeeModel)
        {
            if (!ModelState.IsValid)
            {
                return StatusCode(400, new { Message = "BadRequest!" });
            }
            try
            {
                var response = await _employeeMgnt.UpdateEmployee(employeeModel);
                if (response.Code == 404)
                {
                    return NotFound(new { Message = response.Message });
                }
                return Ok(new { Message = response.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Message = ex.Message });
            }
        }
        [HttpDelete("DeleteEmployee{id}")]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            try
            {
                var response = await _employeeMgnt.DeleteEmployee(id);
                if (response.Code == 404)
                {
                    return NotFound(new { Message = response.Message });
                }
                return Ok(new { Message = response.Message });
            }
            catch (Exception ex)
            {

                return StatusCode(500, new { Message = ex.Message });
            }
        }
    }
}
