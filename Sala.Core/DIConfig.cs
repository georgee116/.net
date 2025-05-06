using Microsoft.Extensions.DependencyInjection;
using Sala.Core.Services;
using Sala.Core.Services.Interfaces;
using Sala.Database.Repositories;

public static class DIConfig
{
    public static void AddCoreServices(this IServiceCollection services)
    {
        services.AddScoped<ISportsHallService, SportsHallService>();
        services.AddScoped<IReservationService, ReservationService>();
        services.AddScoped<SportsHallRepository>();
        services.AddScoped<ReservationRepository>();
    }
}
