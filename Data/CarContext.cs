using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using CarswithSQLDatabase.Models;

namespace CarswithSQLDatabase.Data
{
    public class CarContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=MSI;Initial Catalog=CarManagementDB;Integrated Security=True;TrustServerCertificate=True;");
        }
    }
}
