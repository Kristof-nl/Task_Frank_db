using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Frank_db.Models
{
    class DatabaseContext : DbContext
    {
        public DbSet<Person> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"data source = (localdb)\Local; initial catalog=PersonAddressDB; persist security info = True;");
            }
                base.OnConfiguring(optionsBuilder);
        }
    }
    
}
