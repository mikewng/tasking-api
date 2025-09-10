using tasking_api.Main.Service;
using tasking_api.Main.Service.Contracts;

namespace tasking_api.Main.Extensions
{
    public static class ProgramExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IBoardService, BoardService>();
            services.AddScoped<ITaskService, TaskService>();

            return services;
        }
    }
}
