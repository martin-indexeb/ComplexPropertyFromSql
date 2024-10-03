using ComplexPropertyFromSql.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace ComplexPropertyFromSql.Data
{
  public class EmployeeContext : DbContext
  {
    public DbSet<Employee> Employees { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Employee>(x =>
      {
        x.ComplexProperty(
          y => y.ReviewDay,
          y =>
          {
            y.IsRequired();
            y.Property(z => z.Day).HasColumnName("ReviewDayDay");
            y.Property(z => z.Month).HasColumnName("ReviewDayMonth");
          });
      });
      base.OnModelCreating(modelBuilder);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlite($@"Data Source=.\Employees.db");
      
      // You get the same issue with SQL Server
      //optionsBuilder.UseSqlServer("Server=localhost;Integrated Security=true;Initial Catalog=EmployeesDb;TrustServerCertificate=True");

      base.OnConfiguring(optionsBuilder);
    }
  }
}
