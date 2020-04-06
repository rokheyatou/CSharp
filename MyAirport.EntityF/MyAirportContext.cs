using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace NR.MyAirport.EF
{
    public class MyAirportContext : DbContext   
    {
        public MyAirportContext(DbContextOptions <MyAirportContext> options)
        : base(options)
        { }

        public DbSet<Bagage> Bagages { get; set; }
        public DbSet<Vol> Vols { get; set; }

      /*  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\mssqllocaldb;Database=MyAirportDb;Integrated Security=True");
        }*/
    }
}
