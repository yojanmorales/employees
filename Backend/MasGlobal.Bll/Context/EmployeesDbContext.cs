using MasGlobal.Model;
using Microsoft.EntityFrameworkCore;

namespace MasGlobal.Bll.Context
{
    public class EmployeesDbContext : DbContext, IEmployeesDbContext
    {
        public EmployeesDbContext(DbContextOptions<EmployeesDbContext> options)
 : base(options)
        {
        }


        public DbSet<Employee> Employees { get; set; }
    }
}
