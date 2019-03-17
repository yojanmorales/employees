using MasGlobal.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MasGlobal.Contracts
{
    public interface IApiEmployeeClient
    {

        Task<Employee> GetById(int id);


        Task<IEnumerable<Employee>> Get();
    }
}
