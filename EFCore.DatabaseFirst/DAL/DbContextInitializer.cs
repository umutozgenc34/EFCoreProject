

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EFCore.DatabaseFirst.DAL;
public class DbContextInitializer
{
    public static IConfigurationRoot Configuration; //appsettings.json okuyabilmek için
    public static DbContextOptionsBuilder<AppDbContext> OptionsBuilder; //veritabanıyla ilgili optionsları belirteceğimiz yer

    public static void Build()
    {
        var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).
            AddJsonFile("appsettings.json", optional:true,reloadOnChange:true);

        Configuration = builder.Build();
        //OptionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
        //OptionsBuilder.UseSqlServer(Configuration.GetConnectionString("SqlCon"));
    }
}
