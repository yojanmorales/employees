using MasGlobal.Model;

namespace MasGlobal.Factory
{
    public class MonthtlySalaryFactory : EmployeeDto
    {
        public MonthtlySalaryFactory(Employee employee)
        {
            AnnualSalary = MonthlySalary * 12;
            Name = employee.Name;
            ContractTypeName = employee.ContractTypeName;
            RoleId = employee.RoleId;
            RoleName = employee.RoleName;
            RoleDescription = employee.RoleDescription;
            HourlySalary = employee.HourlySalary;
            MonthlySalary = employee.MonthlySalary;
            Id = employee.Id;
        }
    }
}
