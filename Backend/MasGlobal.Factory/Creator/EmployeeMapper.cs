using MasGlobal.Contracts;
using MasGlobal.Factory.ConcretesCreator;
using MasGlobal.Factory.Enums;
using MasGlobal.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MasGlobal.Factory.Creator
{
    public class EmployeeMapper : IEmployeeMapper
    {
        public EmployeeDto GenerateMapper(Employee employee)
        {

            EmployeeFactory factory = null;
            switch (GetType(employee.ContractTypeName))
            {
                case EmployeeContractType.HourlyAnualSalary:
                    factory = new HourlySalaryBackFactory(employee);
                    break;
                case EmployeeContractType.MonthlyAnualSalary:
                    factory = new MonthtlySalaryBackFactory(employee);
                    break;
            }
            var employeeDtoResult = factory.GetEmployee();
          
            return employeeDtoResult;
        }

        EmployeeContractType GetType(string type)
        {
            Enum.TryParse(type, out EmployeeContractType contractTypeEnum);
            return contractTypeEnum;
        }
    }
}
