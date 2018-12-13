using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBootstart01.Models;
using WebBootstart01.ViewModels;

namespace WebBootstart01.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            EmployeeListViewModel employeeListViewModel = new EmployeeListViewModel();

            EmployeeBusinessLayer empBal = new EmployeeBusinessLayer();

            List<Employee> employees = empBal.GetEmployees();

            List<EmployeeViewModel> empViewModels = new List<EmployeeViewModel>();

            foreach(Employee emp in employees)
            {
                EmployeeViewModel empViewModel = new EmployeeViewModel();
                empViewModel.EmployeeName = emp.Name;
                empViewModel.Salary = emp.Salary.ToString("C");
                if(emp.Salary>10000)
                {
                    empViewModel.SalaryGrade = "高富帅";
                }
                else
                {
                    empViewModel.SalaryGrade = "矮穷丑";
                }
                empViewModels.Add(empViewModel);
            }
           // employeeListViewModel.EmployeeViewList
            return View();
        }
    }
}