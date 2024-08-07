using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inhar_database_linking
{
    public class Ecomm : DbContext
    {
        public DbSet<customer> customers {  get; set; }
        public DbSet<product> product {  get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=VISAL\MSSQLSERVER02;Database=EFCoreDemo;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=true");

        }
    }
}
