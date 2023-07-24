using CRUDAPI.Models.Base;

namespace CRUDAPI.Models
{
    public class Address : BaseEntity
    {
     
        public string Street { get; set; }

        public string Number { get; set; }

        public string City { get; set; }

        public string Region { get; set; }

        public string ZipCode { get; set; }

        public string Complement { get; set; }
         
        
    }
}
