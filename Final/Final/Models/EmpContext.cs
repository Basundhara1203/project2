using Final.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    public class EmpContext : DbContext
    {
        public EmpContext() : base("conStr") { }

       public  DbSet<Employee>Employees{ get;set ;}
    }
}
