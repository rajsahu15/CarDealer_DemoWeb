
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WebApplication1.Models.Entities;


namespace WebApplication1.Models.DataBaseConnection
{
    
    
        public class DatabaseLoader : DbContext
        {
            public DbSet<Clients> Clients { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer(
                    "Server=localhost\\SQLEXPRESS;Database=Entity_Framework_Practice;Trusted_Connection=True;TrustServerCertificate=True");
            }
        }
    
}
