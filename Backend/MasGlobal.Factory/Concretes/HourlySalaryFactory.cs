using MasGlobal.Model;

namespace MasGlobal.Factory
{
    public class HourlySalaryFactory : EmployeeDto
    {

        public HourlySalaryFactory(Employee employee)
        {
            AnnualSalary = 120 * employee.HourlySalary * 12;
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
