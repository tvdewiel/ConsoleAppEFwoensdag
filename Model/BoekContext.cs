using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEFwoensdag.Model
{
    public class BoekContext : DbContext
    {
        public DbSet<Boek> BoekenX { get; set; }
        public DbSet<Auteur> Auteurs { get; set; }
        public DbSet<Uitgeverij> Uitgeverijen { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=NB21-6CDPYD3\\SQLEXPRESS;Initial Catalog=EFwoensdag;Integrated Security=True;TrustServerCertificate=True")
                .LogTo(Console.WriteLine,LogLevel.Information);
        }
    }
}
