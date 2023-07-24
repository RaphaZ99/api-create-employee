using CRUDAPI.Data;
using CRUDAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDAPI.Services
{
    public class SectorService
    {
        private readonly Context _context;

        public SectorService(Context context)
        {
            _context = context;
        }

        public Sector CreateSector(Sector sector)
        {

            if (NameExists(sector.Name))
            {

                throw new InvalidOperationException("Name already registered.");

            }
            _context.Sectors.Add(sector);
            _context.SaveChanges();

            return sector;

        }

        public List<Sector> GetSectors()
        {

            return _context.Sectors.ToList();

        } 

        public bool NameExists(string name)
        {
            return _context.Sectors.Any(p => p.Name == name);
        }

    }
}
