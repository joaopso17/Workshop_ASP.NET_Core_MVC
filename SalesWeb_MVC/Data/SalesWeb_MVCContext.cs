using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWeb_MVC.Models;

namespace SalesWeb_MVC.Data
{
    public class SalesWeb_MVCContext : DbContext
    {
        public SalesWeb_MVCContext (DbContextOptions<SalesWeb_MVCContext> options)
            : base(options)
        {
        }

        public DbSet<SalesWeb_MVC.Models.Department> Department { get; set; } = default!;
    }
}
