using Microsoft.Extensions.DependencyInjection;

using Sala.Database.Repositories;

namespace Sala.Core
{
    public static class DIConfig
    {
        public static void AddCoreServices(this IServiceCollection services)
        {
            // Repositories
            services.AddScoped<SportsHallRepository>();
            services.AddScoped<ReservationRepository>();


        }
    }
}
