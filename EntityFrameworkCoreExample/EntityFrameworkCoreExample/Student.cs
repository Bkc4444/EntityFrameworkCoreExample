using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCoreExample
{
    public class Student
    {
        [Key] // Tell EF Core to make this a Primary Key (PK)
        public int Id { get; set; }

        public string FullName { get; set; }

        public DateTime DateOfBirth { get; set; }

        
        public string EmailAddress { get; set; }
        // open Package Manager Console
        // When ever a change is made that would affect the database you have to do the command
        // Add-Migration followed by a brief name of what was added
        // in this case it was named Add-Migration AddedStudentEmail
        // Then to update the database you have to run the command Update-Database
    }
}
