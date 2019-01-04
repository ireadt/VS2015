﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ContosoUniversity.Models;

namespace ContosoUniversity.DAL
{
    public class SchoolInitializer:System.Data.Entity.DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            var students = new List<Student>
            {
            new Student{FirstMidName="Carson",LastName="Alexander",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Student{FirstMidName="Meredith",LastName="Alonso",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstMidName="Arturo",LastName="Anand",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Student{FirstMidName="Gytis",LastName="Barzdukas",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstMidName="Yan",LastName="Li",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstMidName="Peggy",LastName="Justice",EnrollmentDate=DateTime.Parse("2001-09-01")},
            new Student{FirstMidName="Laura",LastName="Norman",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Student{FirstMidName="Nino",LastName="Olivetto",EnrollmentDate=DateTime.Parse("2005-09-01")}
            };

            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();
            var courses = new List<Course>
            {
            new Course{CourseID=550,Title="Chemistry",Credits=3,},
            new Course{CourseID=560,Title="Microeconomics",Credits=3,},
            new Course{CourseID=650,Title="Macroeconomics",Credits=3,},
            new Course{CourseID=660,Title="Calculus",Credits=4,},
            new Course{CourseID=750,Title="Trigonometry",Credits=4,},
            new Course{CourseID=960,Title="Composition",Credits=3,},
            new Course{CourseID=980,Title="Literature",Credits=4,}
            };
            courses.ForEach(s => context.Courses.Add(s));
            context.SaveChanges();
            var enrollments = new List<Enrollment>
            {
            new Enrollment{StudentID=1,CourseID=560,Grade=Grade.A},
            new Enrollment{StudentID=1,CourseID=550,Grade=Grade.C},
            new Enrollment{StudentID=1,CourseID=560,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=660,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=750,Grade=Grade.E},
            new Enrollment{StudentID=2,CourseID=960,Grade=Grade.E},
            new Enrollment{StudentID=3,CourseID=980},
            new Enrollment{StudentID=4,CourseID=550,},
            new Enrollment{StudentID=4,CourseID=660,Grade=Grade.E},
            new Enrollment{StudentID=5,CourseID=750,Grade=Grade.C},
            new Enrollment{StudentID=6,CourseID=660},
            new Enrollment{StudentID=7,CourseID=980,Grade=Grade.A},
            };
            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();
        }
    }
}