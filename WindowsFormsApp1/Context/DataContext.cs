using System.Data.Entity;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Context
{
    public class DataContext : DbContext
    {
        public DataContext()
        : base("DefaultConnection")
        { }

        public DbSet<Employee> Employers { get; set; }
        public DbSet<Child> Children { get; set; }
    }
}
