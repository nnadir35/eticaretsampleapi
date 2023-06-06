using ETicaretAPI.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace ETicaretAPI.Persistence;

public class DesignTimeDbContextFactory:IDesignTimeDbContextFactory<ECommerceSampleDbContext>
{
    public ECommerceSampleDbContext CreateDbContext(string[] args)
    {
        DbContextOptionsBuilder<ECommerceSampleDbContext> dbContextOptionsBuilder = new();
        dbContextOptionsBuilder.UseNpgsql(Configurations.ConnectionString);
        return new(dbContextOptionsBuilder.Options);
    }
}