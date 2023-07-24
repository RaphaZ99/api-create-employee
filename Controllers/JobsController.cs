using CRUDAPI.Data;
using CRUDAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CRUDAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JobsController : Controller
    {
        private readonly Context _context;
        public JobsController(Context context)
        {
            _context = context;

        }

        [HttpGet]
        public async Task<ActionResult<List<Job>>> GetJobs()
        {
            return await _context.Jobs.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Job>> Post([FromBody] Job job)
        {
            await _context.Jobs.AddAsync(job);
            await _context.SaveChangesAsync();

            return Ok(job);
        }
    }
}