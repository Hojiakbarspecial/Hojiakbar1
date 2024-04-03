using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hojiakbar1
{
    public class Context : DbContext
    {
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-SVRE260; database=dotNet; Integrated Security=true; Encrypt=False");
        }
        public DbSet<Student>? Students { get; set; }
    }
}

