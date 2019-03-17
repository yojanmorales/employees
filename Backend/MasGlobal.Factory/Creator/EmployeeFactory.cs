using MasGlobal.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MasGlobal.Factory.Creator
{
    public abstract class EmployeeFactory
    {
        public abstract EmployeeDto GetEmployee();
    }
}
