using MasGlobal.Contracts;
using MasGlobal.Model;
using MasGlobal.Service.Layers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasGlobal.Factory
{
    public class Facade : IFacade
    {
        private readonly IEmployeeService _service;

        public Facade(IEmployeeService employeeService)
        {
            this._service = employeeService ?? throw new ArgumentNullException(nameof(employeeService));

        }
        public async Task<IQueryable<Employee>> Get()
        {
            var data = await _service.Get();

            return data.AsQueryable();
        }

        public Task<Employee> GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
