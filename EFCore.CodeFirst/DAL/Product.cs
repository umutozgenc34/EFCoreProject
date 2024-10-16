

using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;

namespace EFCore.CodeFirst.DAL;

//indeks oluşturma
[Index(nameof(Name))]
[Index(nameof(Price))]
[Index(nameof(Name),nameof(Price))]
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    [Precision(9,2)]
    public decimal Price { get; set; }
    [Precision(9,2)]
    public decimal DiscountPrice { get; set; }
    public int Stock { get; set; }
    public int Barcode { get; set; }
    public int CategoryId { get; set; }

    //Navigation Property
    public virtual Category Category { get; set; }
    public virtual ProductFeature ProductFeature { get; set; }


}
