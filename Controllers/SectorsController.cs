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
    public class SectorsController : Controller
    {
        private readonly SectorService _sectorService;
        public SectorsController(Context context)
        {
            _sectorService = new SectorService(context);

        }

        [HttpGet]
        public ActionResult<ApiResponse<Sector>> GetSectors()
        {

            try
            {
                return Ok(new ApiResponse<Sector> { Success = true, DataList = _sectorService.GetSectors() });
            }
            catch (Exception ex)
            {
                return BadRequest(new ApiResponse<Sector> { Success = false, ErrorMessage = ex.Message });
            }

        }

        [HttpPost]
        public ActionResult<ApiResponse<Sector>> PostSector([FromBody] Sector sector)
        {
            try
            {
                return Ok(new ApiResponse<Sector> { Success = true, Data = _sectorService.CreateSector(sector) });
            }
            catch (Exception ex)
            {
                return BadRequest(new ApiResponse<Sector> { Success = false, ErrorMessage = ex.Message });
            }
        }
    }
}
