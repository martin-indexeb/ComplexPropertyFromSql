using ComplexPropertyFromSql.Data.ComplexTypes;

namespace ComplexPropertyFromSql.Data.Entities
{
  public class Employee
  {
    public int Id { get; set; }
    public required string Name { get; set; }
    public required DayInYear ReviewDay { get; set; }
  }
}
