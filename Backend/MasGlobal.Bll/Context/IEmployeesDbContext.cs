using MasGlobal.Model;
using Microsoft.EntityFrameworkCore;

namespace MasGlobal.Bll.Context
{
    public interface IEmployeesDbContext
    {
        DbSet<Employee> Employees { get; set; }
    }
}
