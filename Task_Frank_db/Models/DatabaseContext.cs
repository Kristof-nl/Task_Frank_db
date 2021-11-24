using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Frank_db.Models
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Address> Addresses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"data source = (localdb)\Local; initial catalog=PersonAddressDB; persist security info = True;");
            }
                base.OnConfiguring(optionsBuilder);
        }

        /*
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>()
                .HasOne(a => a.Person)
                .WithOne(b => b.Address)
                .HasForeignKey<Address>(b => b.Person_Id);
        }
        */

    }
    
}
