using Microsoft.EntityFrameworkCore;

namespace ERP_API.Infrastructure.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDatabase(this IServiceCollection s, ConfigurationManager configurationManager)
        {
            string connectionString = configurationManager.GetConnectionString("AppDb");

            s.AddDbContext<AppDbContext>( options =>
            {
                options.UseNpgsql(connectionString);
            });

            return s;
        }
    }
}
