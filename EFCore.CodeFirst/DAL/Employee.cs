

using Microsoft.EntityFrameworkCore;

namespace EFCore.CodeFirst.DAL;

public class Employee : BasePerson
{
    [Precision(18,2)]
    public decimal Salary { get; set; }
}
