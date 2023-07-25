using CRUDAPI.Models.Base;

namespace CRUDAPI.Models
{
    public class Employee : BaseEntity
    {

        public Decimal? Salary { get; set; }
        public DateTime ContractStartDate { get; set; }
        public DateTime? ContractEndDate { get; set; }

        public Person Person { get; set; }

        public Job? Job { get; set; }
    }
}
