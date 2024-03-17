using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using TyeBank.Core.Entites;

namespace TyeBank.Core.Entities
{
    public class Employee : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public Guid AddressId { get; set; }
        public Guid PositionId { get; set; }
        public Guid DepartmentId { get; set; }

        public bool IsActive { get; set; }

        public Address Address { get; set; }
        public Position Position{ get; set; }
        public Salary Salary { get; set; }
        public Department Department { get; set; }

    }
}
