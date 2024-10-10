

using Microsoft.Extensions.Configuration;

namespace EFCore.CodeFirst;

public class Initializer
{
    public static IConfigurationRoot Configuration; //appsettings.json okuyabilmek için

    public static void Build()
    {
        var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).
            AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

        Configuration = builder.Build();
        
    }
}
