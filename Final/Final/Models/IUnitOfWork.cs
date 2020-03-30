using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    public interface IUnitOfWork
    {
        EmployeeRepository Employees { get;  }

        int Complete();

    }
}
