using Microsoft.EntityFrameworkCore;
using ORM_TASK.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM_TASK.DAL
{

    internal class DataContext : DbContext
    {

        public DbSet<Group> Groups { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = DESKTOP-77U60MC\\SQLEXPRESS; Database=Academy;Trusted_Connection=True");

        }
    }
}
