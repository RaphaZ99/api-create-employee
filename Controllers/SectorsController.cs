using CRUDAPI.Data;
using CRUDAPI.Models;
using CRUDAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CRUDAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SectorsController : Controller
    {
        private readonly SectorService _sectorService;
        public SectorsController(Context context)
        {
           _sectorService = new SectorService(context);

        }

        [HttpGet]
        public ActionResult<List<Sector>> GetSectors()
        {

            return _sectorService.GetSectors();
           
        }

        [HttpPost]
        public async Task<ActionResult<Sector>> PostSector([FromBody] Sector sector)
        {
            try
            {
              return _sectorService.CreateSector(sector);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            } 
        }
    }
}
