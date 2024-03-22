using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TyeBank.Core.DTOs
{
    public class SalaryDTO : BaseDTO
    {
        public Guid EmployeeId { get; set; }
        public decimal Amount { get; set; }
        public bool IsActive { get; set; }
        public string Currency { get; set; }
    }
}
