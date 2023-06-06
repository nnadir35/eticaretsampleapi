using Microsoft.Extensions.Configuration;

namespace ETicaretAPI.Persistence;

static class Configurations
{
    public static String ConnectionString
    {
        get
        {
            ConfigurationManager configurationManager = new ConfigurationManager();
            configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../ECommerceSample.API"));
            configurationManager.AddJsonFile("appsettings.json");
            return configurationManager.GetConnectionString("PostgreSQL");
        }
    }
}