using Microsoft.EntityFrameworkCore;
using System.Reflection;
using TyeBank.Core.Entites;
using TyeBank.Core.Entities;
using TyeBank.Repository.Configurations;

namespace TyeBank.Repository
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> dbContextOptions):base(dbContextOptions)
        {
           // var employee = new Employee() { Address = new Address() { } };
        }


        public DbSet<Employee> Employees { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Department> Departments{ get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Salary> Salaries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Normalde burada Entity bazında ayarlar yapılır mesela 
            //modelBuilder.Entity<Address>().HasKey(x => x.Id);
            //gibi, ama o zaman da AppDbContext nesnemin içerisi dolacaktır. Bu yüzden her bir Entity ayarını
            //farklı EntitySettings sınıflarında yaparız.  Repository.Configurations klasöründe yaptık.

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()); // Kod içerisinde IEntityTypeConfiguration interface'ine sahip tüm sınıfları "Reflection" ile buldu ve Ayarlarını ekledi.

            //modelBuilder.ApplyConfiguration(new EmployeeConfiguration()); Tek tek elle yapmak istersek bunu kullanırız. Ama 100 tane olursa yazmak zor iş.


            base.OnModelCreating(modelBuilder);
        }
    }
}
