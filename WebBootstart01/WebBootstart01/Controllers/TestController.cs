using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBootstart01.Models;
namespace WebBootstart01.Controllers
{
    public class TestController : Controller
    {
        public string GetString()
        {
            return "你好，MVC";
        }
        public Customer GetCustomer()
        {
            Customer c = new Customer();
            c.CustomerName = "小马";
            c.Address = "mmmmmmm";
            return c;
        }
    }
}