using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexPropertyFromSql.Data.ComplexTypes
{
  [ComplexType]
  public record DayInYear
  {
    public int Day { get; set; }
    public int Month { get; set; }
  }
}
