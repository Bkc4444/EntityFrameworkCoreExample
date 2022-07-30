using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCoreExample
{
    //EF Core Getting started
    //https://docs.microsoft.com/en-us/ef/core/get-started/overview/install
    public class StudentContent : DbContext
    {
        public StudentContent()
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // Data = The desired name for the database
            // Server = The server we are connecting to. LocalDB us included with VS
            // Trusted_Connection - indicates that our windows account should be used
            options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=EFCoreExample;Trusted_Connection=True;");
        }

        /// <summary>
        /// Tell EF Core to track Students in the database
        /// </summary>
        public DbSet<Student> Students { get; set; }
    }
}