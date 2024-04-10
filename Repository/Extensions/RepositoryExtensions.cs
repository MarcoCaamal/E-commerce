using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Repository.Context;

namespace Repository.Extensions
{
    public static class RepositoryExtensions
    {
        private const string ConnectionString = "DefaultConnection";

        public static void AddConfigureRepositoryLayer(this IServiceCollection services, IConfiguration configuration)
        {
            var dbServerVersion = ServerVersion.AutoDetect(configuration.GetConnectionString(ConnectionString));

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseMySql(configuration.GetConnectionString(ConnectionString), dbServerVersion));
        }
    }
}
