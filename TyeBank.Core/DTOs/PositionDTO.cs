using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TyeBank.Core.DTOs
{
    public class PositionDTO : BaseDTO
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public Guid DepartmentId { get; set; }
    }
}
