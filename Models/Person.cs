using CRUDAPI.Models.Base;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUDAPI.Models
{
    public class Person : BaseEntity
    {
       public string? Name { get; set; }

        public string? SocialName { get; set; }
         
        public string? RG { get; set; }
        [MaxLength(11)] 
        public string CPF { get; set; }
        
        public string? PhoneNumber { get; set; }

        public string MobileNumber { get; set; }

        public DateTime? BirthDay { get; set; }

        public Address? Address { get; set; }
         
    }
}
