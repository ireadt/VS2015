using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebBootstart01.Models;

namespace WebBootstart01.Controllers
{
    public class EmployeeBusinessLayer
    {
        public List<Employee> GetEmployees()
        {
            var list = new List<Employee>();
            Employee emp = new Employee();
            emp.Name = "zhazhahui";
            emp.Salary = 12300;
            list.Add(emp);

            emp = new Employee();
            emp.Name = "laji";
            emp.Salary = 2400;
            list.Add(emp);

            emp = new Employee();
            emp.Name = "lese";
            emp.Salary = 23130;
            list.Add(emp);


            return list;
        }
    }
}