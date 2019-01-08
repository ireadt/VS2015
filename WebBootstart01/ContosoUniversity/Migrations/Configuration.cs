namespace ContosoUniversity.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Collections.Generic;
    using ContosoUniversity.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<ContosoUniversity.DAL.SchoolContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "ContosoUniversity.DAL.SchoolContext";
        }

        protected override void Seed(ContosoUniversity.DAL.SchoolContext context)
        {
            var students = new List<Student>
            {
            new Student{FirstMidName="¿¨¶ûÉ­",LastName="Â¬±¾Î°",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Student{FirstMidName="Ã·ÈðµÏË¹",LastName="½Ü¿ËÂí",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstMidName="°¢Í¼ÂÞ",LastName="´¿¡¤¼òÀ­»ù¡¤´ÄµÂ",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Student{FirstMidName="¸ñµÙ",LastName="Ð¡½ã½ã",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstMidName="Ñî",LastName="Ð¡¸ç¸ç",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstMidName="Åå¼ª",LastName="Ð¡½ã½ã",EnrollmentDate=DateTime.Parse("2001-09-01")},
            new Student{FirstMidName="ÀÍÀ­",LastName="Ð¡½ã½ã",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Student{FirstMidName="ÄáÅµ",LastName="Ð¡¸ç¸ç",EnrollmentDate=DateTime.Parse("2005-09-01")}
            };



            

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
