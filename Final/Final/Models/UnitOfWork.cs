using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Final.Models;

namespace Final

{
    public class UnitOfWork : IUnitOfWork
    {
     
        private EmployeeRepository crepository;
        private EmpContext cc;
        public UnitOfWork(EmpContext cc) {
            this.cc = cc;
            crepository = new EmployeeRepository(cc);
        }


        public EmployeeRepository Employees {
            get {
                return crepository;
            }
        }
    
    
     /*   public EmployeeRepository Employees
        {
            get
            {
                throw new NotImplementedException();
            }
        }*/

        public int Complete()
        {
            return cc.SaveChanges();
        }

        public void Dispose()
        {
            cc.Dispose();
        }


    }
}
