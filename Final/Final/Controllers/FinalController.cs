using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Final.Models;

namespace Final.Controllers
{
    public class FinalController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            IUnitOfWork i = new UnitOfWork(new EmpContext());
            List<Employee> c = i.Employees.GetAll().ToList();
            
          
           
            return View(c);

        }
        // GET: Customer
      

        public ActionResult GetEmployees()
        {
            return View();
        }
        [HttpPost]
        public ActionResult GetEmployees(Employee em)
        {
            if (ModelState.IsValid)
            {

                IUnitOfWork i = new UnitOfWork(new EmpContext());
                i.Employees.Add(em);
                i.Complete();
                return RedirectToAction("Index");


            }
            else
            {
                return View(em);
            }
        }

              [HttpGet]
        public ActionResult Edit(int id)
        {
            IUnitOfWork iu = new UnitOfWork(new EmpContext());
            Employee e = iu.Employees.Find(c => c.EmployeeID == id).FirstOrDefault();
            return View(e);
        }

        [HttpPost]
        public ActionResult Edit(Employee e)
        {
            if (ModelState.IsValid)
            {
                IUnitOfWork iu = new UnitOfWork(new EmpContext());
                iu.Employees.Modify(e);
                iu.Complete();
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            IUnitOfWork iu = new UnitOfWork(new EmpContext());
            Employee e = iu.Employees.Find(c => c.EmployeeID == id).FirstOrDefault();
            iu.Employees.Remove(e);
            iu.Complete();
            return RedirectToAction("Index");
        }











    

    }
}