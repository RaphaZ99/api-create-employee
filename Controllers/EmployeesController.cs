using CRUDAPI.Common;
using CRUDAPI.Data;
using CRUDAPI.Models;
using CRUDAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CRUDAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeesController : ControllerBase
    {
        private readonly Context _context;
        private EmployeeService _employeerService;

        public EmployeesController(Context context)
        {
            _context = context;
            _employeerService = new EmployeeService(_context);
        }
         
        [HttpPost]
        public ActionResult<ApiResponse<Employee>> PostEmployeer([FromBody]Employee employee)
        {
            try
            {
                  if (_employeerService.CreateEmployeer(employee))
                {
                    return Ok(new ApiResponse<Employee> { Success = true, Data = employee}) ;
                }
            }catch (Exception ex)
            {
                return BadRequest(new ApiResponse<Employee> { Success = false, Data = employee, ErrorMessage = ex.Message});
            }

            return Ok();
        } 
    }
}
