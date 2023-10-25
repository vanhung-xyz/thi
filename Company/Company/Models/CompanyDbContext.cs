using Microsoft.EntityFrameworkCore;

namespace Company.Models
{
    public class CompanyDbContext: DbContext
    {

        public CompanyDbContext()
        {
        }

        public CompanyDbContext(DbContextOptions<CompanyDbContext> options)
           : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-QG7K8HCB\\SQLEXPRESS;Initial Catalog=Company;User ID=sa;Password=241403;Encrypt=False");
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
