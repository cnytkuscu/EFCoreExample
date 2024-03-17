using TyeBank.Core.Entites;

namespace TyeBank.Core.Entities
{
    public class Position : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public Guid DepartmentId { get; set; }

        public ICollection<Employee> Employees { get; set; }
        public Department Department { get; set; }
    }
}
