

using System.Reflection.Metadata.Ecma335;

namespace EFCore.CodeFirst.DAL;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Price { get; set; }
    public int Stock { get; set; }
    public int Barcode { get; set; }
}
