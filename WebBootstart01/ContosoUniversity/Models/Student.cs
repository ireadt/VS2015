using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace ContosoUniversity.Models
{
    public class Student
    {
        
        public int ID { get; set; }
        [Display(Name = "姓名")]
        public string LastName { get; set; }
        [Display(Name ="用户名")]
        public string FirstMidName { get; set; }
        [Display(Name = "日期")]
        public DateTime EnrollmentDate { get; set; }

        public string Secret { get; set; }
        [Display(Name ="入学年份")]
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}