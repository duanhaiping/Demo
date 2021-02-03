using Demo.Data_Access_Layer;
using Demo.Models;
using Demo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo.Controllers
{
    [Authorize]
    public class EmployeeController:Controller
    {

    
        public ActionResult GetView()
        {
           
            Employee emp = new Employee
            {
                FirstName = "sukesh",
                LastName = "marla",
                Salary = 200000
            };
            //ViewData["Employee"] = employee;

            //Employee employeebag = new Employee
            //{
            //    FirstName = "cormen",
            //    LastName = "baff",
            //    Salary = 1231
            //};
            //ViewBag.EmployeeBag = employeebag;

            EmployeeViewModel employeeViewModel = new EmployeeViewModel
            {

                EmployeeName = emp.FirstName + "" + emp.LastName,
                Salary = emp.Salary.ToString("C"),
                UserName = "admin",
            };
            if (emp.Salary > 15000)
            {
                employeeViewModel.SalaryColor= "yellow";
            }
            else
            {
                employeeViewModel.SalaryColor = "green";
            }
            if(string.IsNullOrWhiteSpace(employeeViewModel.EmployeeName))
            {
                ModelState.AddModelError("EmployeeName", "test EmployeeName error");
            }
            if(employeeViewModel.UserName== "admin")
            {
                ModelState.AddModelError("UserName", "test UserName error");
            }
            if (!ModelState.IsValid)
            {
                throw new Exception("ModelState.IsValid FALSE");
                //执行更新
            }
            return View(employeeViewModel);
        }
    }
}