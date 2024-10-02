using ComplexPropertyFromSql.Data;
using Microsoft.EntityFrameworkCore;

var db = new EmployeeContext();
db.Database.EnsureCreated();
// load normally
try
{
  var list1 = db.Employees.ToList();
  Console.WriteLine("Loaded employees by dbcontext");
} catch
{
  Console.WriteLine("Failed to load employees by dbcontext");
}
// load by sql
try
{
  var list2 = db.Employees.FromSql($"select * from Employees").ToList();
  Console.WriteLine("Loaded employees by sql");
} catch (Exception ex)
{
  Console.WriteLine($"Failed to load employees by sql: {ex.Message}");
}

try
{
  var list2 = db.Employees.FromSql($"select Id, Name, ReviewDayDay as ReviewDay_Day, ReviewDayMonth as ReviewDay_Month from Employees").ToList();
  Console.WriteLine("Loaded employees by workaround sql");
} catch (Exception ex)
{
  Console.WriteLine($"Failed to load employees by amended sql: {ex.Message}");
}
