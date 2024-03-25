using Microsoft.EntityFrameworkCore;
using SalesWeb_MVC.Models;

namespace SalesWeb_MVC.Data
{
    public class DepartmentsContext : DbContext
    {
        public DepartmentsContext(DbContextOptions<DepartmentsContext> opitions) : base(opitions) { }

        public DbSet<Department> Department { get; set; }

    }
}
