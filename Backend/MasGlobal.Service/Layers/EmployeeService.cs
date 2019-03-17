using MasGlobal.Contracts;
using MasGlobal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasGlobal.Service.Layers
{
    public partial class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeMapper _employeeMapper;
        private readonly IApiEmployeeClient _apiEmployeeClient;

        public EmployeeService(IEmployeeMapper employeeMapper, IApiEmployeeClient apiEmployeeClient)
        {
            this._employeeMapper = employeeMapper ?? throw new ArgumentNullException(nameof(employeeMapper));
            this._apiEmployeeClient = apiEmployeeClient ?? throw new ArgumentNullException(nameof(apiEmployeeClient));

        }
        public async Task<IQueryable<Employee>> Get()
        {
            var result = await _apiEmployeeClient.Get();
            if (result is null || !result.Any())
            {
                return new List<Employee>().AsQueryable();
            }
            return result.Select(e => _employeeMapper.GenerateMapper(e)).AsQueryable();
        }

        public Task<Employee> GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
