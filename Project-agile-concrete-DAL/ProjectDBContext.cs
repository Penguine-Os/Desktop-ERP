using Microsoft.EntityFrameworkCore;
using Project_agile_concrete_models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_agile_concrete_DAL
{
    public class ProjectDBContext : DbContext
    {
        public DbSet<Klant> Klanten { get; set; }
        public DbSet<Factuur> Facturen { get; set; }
        public DbSet<Product> Producten { get; set; }
        public DbSet<Winkel> Winkels { get; set; }
        public DbSet<Categorie> Categories { get; set; }
        public DbSet<Stock> Stock { get; set; }
        public DbSet<Dienst> Diensten { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=baker.local.thomasmore.be\\GSQLEDU01,45001;Database=r0901225;User Id = r0901225;Password=sql4you;");
        }
    }
}
