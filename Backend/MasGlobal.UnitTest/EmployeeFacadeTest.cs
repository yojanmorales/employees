using MasGlobal.Contracts;
using MasGlobal.Factory;
using MasGlobal.Model;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace MasGlobal.UnitTest
{
    public class EmployeeFacadeTest
    {
        private readonly Mock<IEmployeeService> _employeeServiceMock;
        private IFacade facade => new Facade(_employeeServiceMock.Object);

        private new List<Employee> internalModels = new List<Employee>()
            {
                new Employee()
                {
                    Id=0,
                    Name="Player 1",
                    ContractTypeName="HourlySalaryEmployee"
                }
            };

        public EmployeeFacadeTest()
        {
            _employeeServiceMock = new Mock<IEmployeeService>();
        }
        private void SetupGet()
        {
            _employeeServiceMock.Setup(a => a.Get()).ReturnsAsync(() => new List<Employee>()
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
        [Trait("Facade", "Employee")]
        public void Get_Successful()
        {
            //Assemble
            SetupGet();

            //Action
            var actual = facade.Get();

            //Assert
            Assert.Equal(internalModels.AsQueryable(), internalModels.AsQueryable());
        }

    }
}
