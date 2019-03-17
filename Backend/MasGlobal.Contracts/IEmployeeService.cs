using MasGlobal.Model;
using System.Linq;
using System.Threading.Tasks;

namespace MasGlobal.Contracts
{
    public interface IEmployeeService
    {
        Task<IQueryable<Employee>> Get();
        Task<Employee> GetById(int id);
    }
}
