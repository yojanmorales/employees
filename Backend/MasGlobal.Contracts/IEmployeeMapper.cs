using MasGlobal.Model;

namespace MasGlobal.Contracts
{
    public interface IEmployeeMapper
    {
        EmployeeDto GenerateMapper(Employee employee);
    }
}
