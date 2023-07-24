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
        public ActionResult<Person> PostEmployeer([FromBody]Employee employee)
        {
            try
            {
                if (_employeerService.CreateEmployeer(employee))
                {
                    return Ok("Successfully registered employee");
                }
            }catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return Ok();
        }
        /*
        [HttpPut]
        public async Task<ActionResult> PutPerson(Person person)
        {
            _context.Persons.Update(person);
            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpDelete("{personId}")]
        public async Task<ActionResult> DeletePerson(Guid personId)
        {
            Person person = await _context.Persons.FindAsync(personId);

            if (person != null)
            {
                _context.Remove(person);
                await _context.SaveChangesAsync();
            }
            else
            {
                return NotFound("Pessoa não encontrada nos registros");
            }

            return Ok();*/
        
    }
}
