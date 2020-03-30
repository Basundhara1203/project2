
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Final;

namespace Final
{
    public class Repository<T> :  IRepository<T> where T : class
    {
        EmpContext context = null;
        //private EmployeeRepository.EmpContext context1;

        public Repository( EmpContext context) {
            this.context = context;
        }

       // public Repository(EmployeeRepository.EmpContext context1)
        //{
          //  this.context1 = context1;
        //}

        public void Add(T entity)
        {
            context.Set<T>().Add(entity);
        }

        public IEnumerable<T> Find(Func<T,bool> predicate)
        {
            return context.Set<T>().Where(predicate);
        }

        public IEnumerable<T> GetAll()
        {
            return context.Set<T>().AsEnumerable();
        }

        public void Modify(T entity)
        {
            context.Entry<T>(entity).State = System.Data.Entity.EntityState.Modified;
        }

        public void Remove(T entity)
        {
            context.Set<T>().Remove(entity);
        }
    }
}
