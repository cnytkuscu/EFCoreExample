using TyeBank.Core.Entites;

namespace TyeBank.Core.Entities
{
    public class Salary : BaseEntity
    {
        public Guid EmployeeId { get; set; }
        public decimal Amount { get; set; }
        public bool IsActive { get; set; }
        public string Currency { get; set; }

        public Employee Employee{ get; set; }
    }
}
