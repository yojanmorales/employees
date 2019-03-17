using MasGlobal.Contracts;
using MasGlobal.Model;
using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Query;
using Microsoft.AspNet.OData.Routing;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace MasGlobal.Employees.Controllers
{
    [ODataRoutePrefix("employees")]
    public class EmployeesController : ODataController
    {

        private ODataValidationSettings _validationSettings = new ODataValidationSettings();

        public IEmployeeService _service;

        public EmployeesController(IEmployeeService service)
        {
            _service = service;
        }



        [HttpGet]
        [EnableQuery]
        public async Task<IQueryable<Employee>> Get()
        {
            return await _service.Get();
        }


    }
}
