using EFCore.CodeFirst;
using EFCore.CodeFirst.DAL;
using Microsoft.EntityFrameworkCore;

Initializer.Build();

using (var _context = new AppDbContext())
{

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
