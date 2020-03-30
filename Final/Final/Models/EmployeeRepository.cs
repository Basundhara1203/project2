using Final.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    public class EmployeeRepository : Repository<Employee>,IRepository<Employee>
    {
        public EmployeeRepository( EmpContext context) : base(context) {
            
        }
       EmpContext  context = new EmpContext();
        //public IEnumerable<Customer> Name()
        //{
          // return context.Customers.OrderBy(c => c.CName).ToList();
        //}





    }
}
