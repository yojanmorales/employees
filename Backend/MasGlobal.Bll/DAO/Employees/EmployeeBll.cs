using MasGlobal.Bll.Context;
using MasGlobal.Model;
using System.Linq;

namespace MasGlobal.Bll.DAO.Employees
{
    public class EmployeeBll : IEmployeeBll
    {
        private readonly IRepository<Employee> _employeeRepository;

        public EmployeeBll(IRepository<Employee> employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public IQueryable<Employee> Get()
        {
            return _employeeRepository.GetAll();
        }
    }
}
