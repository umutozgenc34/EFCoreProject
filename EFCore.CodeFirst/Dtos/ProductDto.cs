

namespace EFCore.CodeFirst.Dtos;

public class ProductDto
{
    public string CategoryName { get; set; }
    public string ProductName { get; set; }
    public decimal Price { get; set; }
    public int? Width { get; set; }
}
