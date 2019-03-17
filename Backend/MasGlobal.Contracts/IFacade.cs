using MasGlobal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasGlobal.Contracts
{
    public interface IFacade
    {
        Task<IQueryable<Employee>> Get();
        Task<Employee> GetById(int id);
    }
}
