using Dapper;
using DapperMVCCRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DapperMVCCRUD.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View(DapperORM.ReturnList<Employee>("EmployeeViewAll"));
        }

        [HttpGet]
        public ActionResult AddOrEdit(int id = 0)
        {
            if (id == 0)
                return View();
            else {
                DynamicParameters param = new DynamicParameters();
                param.Add("@EmployeeID",id);
                return View(DapperORM.ReturnList<Employee>("EmployeeViewByID",param).FirstOrDefault<Employee>());
            }
        }
        [HttpPost]
        public ActionResult AddOrEdit(Employee employee)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@EmployeeID", employee.EmployeeID);
            param.Add("@Name", employee.Name);
            param.Add("@Position", employee.Position);
            param.Add("@Age", employee.Age);
            param.Add("@salary", employee.Salary);
            DapperORM.ExcuteWithoutReturn("EmployeeAddOrEdit", param);

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@EmployeeID", id);
            DapperORM.ExcuteWithoutReturn("EmployeeDeleteByID", param);
            return RedirectToAction("Index");
        }
    }
}