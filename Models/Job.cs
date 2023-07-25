using CRUDAPI.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUDAPI.Models
{
    public class Job : BaseEntity
    { 
        public string Name { get; set; }

        [ForeignKey("SectorId")]
        public Sector? Sector { get; set; }

        public int SectorId { get; set; }

    }
}
