using Microsoft.EntityFrameworkCore;

namespace CodeFirstEF.Context
{
    public class EmployeeDbContext:DbContext
    {

        public EmployeeDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<userdetails> userdetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)

        { 
            modelBuilder.Entity<userdetails>().HasNoKey();
        ////    modelBuilder.Entity<Employee>().HasData(
        ////        new Employee { EmployeeId = 1, Name = "Nikhil", Designation = "Developer", Address = "New York", CompanyName = "XYZ Inc", Salary = 30000 },
        ////        new Employee { EmployeeId = 2, Name = "Reyansh", Designation = "Manager", Address = "New York", CompanyName = "ABC Inc", Salary = 50000 },
        ////        new Employee { EmployeeId = 3, Name = "Pulakit", Designation = "Consultant", Address = "New Delhi", CompanyName = "XYZ Inc", Salary = 20000 },
        ////         new Employee { EmployeeId = 4, Name = "Saurabh", Designation = "Developer", Address = "New York", CompanyName = "XYZ Inc", Salary = 30000 },
        ////        new Employee { EmployeeId = 5, Name = "Hemant", Designation = "Manager", Address = "New York", CompanyName = "ABC Inc", Salary = 50000 },
        ////        new Employee { EmployeeId = 6, Name = "Aarav", Designation = "Consultant", Address = "New Delhi", CompanyName = "XYZ Inc", Salary = 20000 }
        ////       );
    }
    }
}
