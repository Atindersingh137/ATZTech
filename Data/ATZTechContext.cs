using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ATZTech.Models;

namespace ATZTech.Data
{
    public class ATZTechContext : DbContext
    {
        public ATZTechContext (DbContextOptions<ATZTechContext> options)
            : base(options)
        {
        }

        public DbSet<ATZTech.Models.Product> Product { get; set; }

        public DbSet<ATZTech.Models.User> User { get; set; }

        public DbSet<ATZTech.Models.Order> Order { get; set; }
    }
}
