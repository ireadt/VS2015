using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebBootstart01.ViewModels
{
    public class EmployeeListViewModel
    {
        public string UserName { get; set; }
        public List<EmployeeListViewModel> EmployeeViewList { get; set; }
    }
}