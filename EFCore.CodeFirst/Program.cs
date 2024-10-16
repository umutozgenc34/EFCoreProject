using EFCore.CodeFirst;
using EFCore.CodeFirst.DAL;
using Microsoft.EntityFrameworkCore;

Initializer.Build();

using (var _context = new AppDbContext())
{

    //var category = new Category() {Name = "Kalemler" };
    //category.Products.Add(new() { Name = "Kalem1", Price = 200, Barcode = 153, Stock = 50, ProductFeature = new() 
    //{ Color = "Red",Height = 200,Width = 300} });
    //category.Products.Add(new()
    //{
    //    Name = "Kalem2",
    //    Price = 300,
    //    Barcode = 155,
    //    Stock = 510,
    //    ProductFeature = new()
    //    { Color = "Blue", Height = 300, Width = 200 }
    //});

    //_context.Add(category);
    //_context.SaveChanges();

    //Eager Loading
    //var categoryWithProducts = _context.Categories.Include(x=> x.Products).ThenInclude(x=> x.ProductFeature).First();

    //Explicit Loading
    //var category = _context.Categories.First();
    ////
    ////
    ////
    //if (true)
    //{
    //    _context.Entry(category).Collection(x => x.Products).Load();
    //    category.Products.ForEach(x =>
    //    {
    //        Console.WriteLine(x.Name);
    //    });
    //}

    //Lazy Loading

    //var category = _context.Categories.First();
    //Console.WriteLine("category çekildi");
    //var products = category.Products;
    //foreach (var item in products)
    //{
    //    //(N+1 Problem)
    //    var productFeature = item.ProductFeature;
    //}
    //Console.WriteLine("işlem bitti");









    //var product = _context.Products.First();

    //product.Name = "Test";
    //product.Stock = 15;
    ////_context.Products.Update(product); EFCore otomatik olarak modified yapıyor bu methoda gerek yok
    //_context.SaveChanges();


    //_context.Products.Add(new() { Name = "Kitap2",  Price=500,  Barcode = 123, Stock = 30 });
    //_context.Products.Add(new() { Name = "Kitap2", Price = 500, Barcode = 123, Stock = 30 });
    //_context.Products.Add(new() { Name = "Kitap2", Price = 500, Barcode = 123, Stock = 30 });

    //_context.SaveChanges();


    //var products = await _context.Products.AsNoTracking().ToListAsync();



    //products.ForEach(p => 
    //{

    //    var state = _context.Entry(p).State;

    //Console.WriteLine($"{p.Id} : {p.Name} - {p.Price} - {p.Stock} state : {state}");


    //});



}
