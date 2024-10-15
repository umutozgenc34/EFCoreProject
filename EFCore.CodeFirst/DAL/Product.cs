﻿

using System.Reflection.Metadata.Ecma335;

namespace EFCore.CodeFirst.DAL;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }
    public int Barcode { get; set; }
    public int CategoryId { get; set; }

    //Navigation Property
    public Category Category { get; set; }


}
