using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    
    public class ReCapContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-PVEILPL; Database=DB_ReCapProject;Trusted_Connection=True;TrustServerCertificate=True;");
            //Data Source=DESKTOP-PVEILPL;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False

        }

        public DbSet<Car> TBL_CARS { get; set; }
        //public DbSet<Brand> Categories { get; set; }
        //public DbSet<Color> Customers { get; set; } 
    }
}
