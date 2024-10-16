

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace EFCore.CodeFirst.DAL;

public class AppDbContext : DbContext
{
    //TPH
    //public DbSet<BasePerson> Persons { get; set; }
    //public DbSet<Manager> Managers { get; set; } //Base class DbSet edilmeden sadece Managers ve Employees oluşturulursa
    //                                             // BasePersonun özelliklerini de tutan 2 tablo oluşturulur BasePerson da
    //                                             // DbSet edilirse Tek bir ortak tablo oluşur.
    //public DbSet<Employee> Employees { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    //public DbSet<Student> Students { get; set; }
    //public DbSet<Teacher> Teachers { get; set; }
    public DbSet<ProductFeature> ProductFeatures { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        Initializer.Build();
        //optionsBuilder.LogTo(Console.WriteLine,LogLevel.Information).UseLazyLoadingProxies().UseSqlServer(Initializer.Configuration.GetConnectionString("SqlCon"));
        optionsBuilder.UseSqlServer(Initializer.Configuration.GetConnectionString("SqlCon"));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //indeks oluşturma
        //modelBuilder.Entity<Product>().HasIndex(x => x.Name).IncludeProperties(x => new { x.Price,x.Stock} );
        //contrait
        modelBuilder.Entity<Product>().HasCheckConstraint("PriceDiscountCheck", "[Price] > [DiscountPrice]");
        

        //TPT
        //modelBuilder.Entity<BasePerson>().ToTable("Persons");
        //modelBuilder.Entity<Employee>().ToTable("Employees");
        //modelBuilder.Entity<Manager>().ToTable("Managers");


        //onetomany
        //modelBuilder.Entity<Category>().HasMany(x=> x.Products).WithOne(x => x.Category).HasForeignKey(x=> x.CategoryId);
        //onetoone
        //modelBuilder.Entity<Product>().HasOne(x => x.ProductFeature).WithOne(x => x.Product).HasForeignKey<ProductFeature>(x=> x.ProductId);
        //manytomany
        //modelBuilder.Entity<Student>().HasMany(x => x.Teachers).WithMany(x => x.Students).
        //UsingEntity<Dictionary<string, object>>(
        //"StudentTeacher",
        //x => x.HasOne<Teacher>().WithMany().HasForeignKey("TeacherId").HasConstraintName("FK_TeacherId"),
        //x => x.HasOne<Student>().WithMany().HasForeignKey("StudentId").HasConstraintName("FK_StudentId")
        //);

        //base.OnModelCreating(modelBuilder);
    }


    //public override int SaveChanges()
    //{
    //    ChangeTracker.Entries().ToList().ForEach(e =>
    //    {
    //        if (e.Entity is Product p)
    //        {
    //            if (e.State == EntityState.Added)
    //            {
    //                p.CreatedDate = DateTime.Now;
    //            }
    //        }
    //    }

    //    );

    //    return base.SaveChanges();
    //}
}
