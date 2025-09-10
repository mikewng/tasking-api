using Microsoft.EntityFrameworkCore;
using tasking_api.Infrastructure.Context;
using tasking_api.Main.Data;
using tasking_api.Main.Data.Contracts;
using tasking_api.Main.Service;
using tasking_api.Main.Service.Contracts;

namespace tasking_api.Infrastructure.Extensions
{
    public static class ProgramExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            // Database configuration
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(
                    configuration.GetConnectionString("DefaultConnection"),
                    sqlServerOptions =>
                    {
                        sqlServerOptions.EnableRetryOnFailure(
                            maxRetryCount: 3,
                            maxRetryDelay: TimeSpan.FromSeconds(30),
                            errorNumbersToAdd: null);
                    });
            });

            // Repository registrations
            services.AddScoped<IBoardTaskRepository, BoardTaskRepository>();
            services.AddScoped<IBoardRepository, BoardRepository>();

            // Service registrations
            services.AddScoped<IBoardService, BoardService>();
            services.AddScoped<IBoardTaskService, BoardTaskService>();

            return services;
        }
    }
}
