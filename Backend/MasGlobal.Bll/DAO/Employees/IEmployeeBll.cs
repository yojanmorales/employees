using MasGlobal.Model;
using System.Linq;

namespace MasGlobal.Bll.DAO.Employees
{
    public interface IEmployeeBll
    {
        IQueryable<Employee> Get();
    }
}
