using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebBootstart01.Models
{
    public class Employee
    {
        [Key]
        public string Name { get; set; }
        public int Salary { get; set; }

        public string Client { get; set; }
        public string From { get; set; }
    }
}