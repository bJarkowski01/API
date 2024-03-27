using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace API
{
    internal class CurrencyContext : DbContext
    {
        public DbSet<CurrencyData> Currencies { get; set; }
        public CurrencyContext()
        {
        Database.EnsureCreated() ;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
        options.UseSqlite("Data Source=C:\\Users\\barte\\source\\repos\\API\\API\\Value.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        modelBuilder.Entity<CurrencyData>() . HasData(
        new CurrencyData() {Id = 1, Date = DateTime.Today,  Timestamp=1238383463, Base="USD", CHF = 4.3232d, EUR=3.33d, GBP=2.22d, JPY=3.422D, PLN=5.33},
        new CurrencyData() {Id = 2, Date = DateTime.Today.AddDays(-1), Timestamp=1134438463, Base = "USD", CHF = 3.442d, EUR = 2.33d, GBP = 5.22d, JPY = 6.422D, PLN = 7.33 }
        );
        }
    }
}
