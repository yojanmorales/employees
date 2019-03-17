using MasGlobal.Factory.Creator;
using MasGlobal.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MasGlobal.Factory.ConcretesCreator
{
    public class HourlySalaryBackFactory : EmployeeFactory
    {
        public Employee _employee { get; set; }
        public HourlySalaryBackFactory(Employee employee)
        {
            _employee = employee;
        }
        public override EmployeeDto GetEmployee()
        {
            return new HourlySalaryFactory(_employee);
        }
    }
}
