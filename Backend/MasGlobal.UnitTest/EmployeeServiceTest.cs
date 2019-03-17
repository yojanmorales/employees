using MasGlobal.Contracts;
using MasGlobal.Model;
using MasGlobal.Service.Layers;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace MasGlobal.UnitTest
{
    public class EmployeeServiceTest
    {
        private readonly Mock<IEmployeeMapper> _employeeMapper;
        private readonly Mock<IApiEmployeeClient> _apiEmployeeClient;

        private IEmployeeService service => new EmployeeService(_employeeMapper.Object, _apiEmployeeClient.Object);

        private new List<Employee> internalModels = new List<Employee>()
            {
                new Employee()
                {
                    Id=0,
                    Name="Player 1",
                    ContractTypeName="HourlySalaryEmployee"
                }
            };

        public EmployeeServiceTest()
        {
            _employeeMapper = new Mock<IEmployeeMapper>();
            _apiEmployeeClient = new Mock<IApiEmployeeClient>();
        }
        private void SetupGet()
        {
            _apiEmployeeClient.Setup(a => a.Get()).ReturnsAsync(() => new List<Employee>()
            {
                new Employee()
                {
                    Id=0,
                    Name="Juan",
                    ContractTypeName="HourlySalaryEmployee"
                }
            }.AsQueryable());
        }

        [Fact]
        [Trait("Service", "Employee")]
        public void Get_Successful()
        {
            //Assemble
            SetupGet();

            //Action
            var actual = service.Get();

            //Assert
            Assert.Equal(internalModels.AsQueryable(), internalModels.AsQueryable());
        }
    }
}
