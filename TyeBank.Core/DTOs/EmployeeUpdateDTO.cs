using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TyeBank.Core.DTOs
{
    public class EmployeeUpdateDTO  
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsActive { get; set; }
        public Guid AddressId { get; set; }
        public Guid PositionId { get; set; }
        public Guid DepartmentId { get; set; }
    }
}
