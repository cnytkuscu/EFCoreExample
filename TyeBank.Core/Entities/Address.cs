using TyeBank.Core.Entites;

namespace TyeBank.Core.Entities
{
    public class Address : BaseEntity
    {
        public string Country { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string NeighborHood { get; set; }
        public string Street { get; set; }
        public string PostalCode { get; set; }

        public Employee Employee { get; set; }
    }
}
