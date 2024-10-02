using ComplexPropertyFromSql.Data;
using Microsoft.EntityFrameworkCore;

var db = new EmployeeContext();
db.Database.EnsureCreated();
var list1 = db.Employees.ToList();
var list2 = db.Employees.FromSql($"select * from Employees").ToList();