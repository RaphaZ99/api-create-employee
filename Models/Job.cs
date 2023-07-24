using CRUDAPI.Models.Base;

namespace CRUDAPI.Models
{
    public class Job : BaseEntity
    { 
        public string Name { get; set; }
  
        public Sector Sector { get; set; }

    }
}
