using TransferRoomInterviewApp.Server.BusinessLogic.Services;
using TransferRoomInterviewApp.Server.BusinessLogic.Services.Interfaces;
using TransferRoomInterviewApp.Server.DataAccess;
using TransferRoomInterviewApp.Server.DataAccess.Interfaces;
using TransferRoomInterviewApp.Server.Infrastructure;
using TransferRoomInterviewApp.Server.Infrastructure.Interfaces;

namespace TransferRoomInterviewApp.Server
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection ConfigureDependencies(this IServiceCollection services)
        {
            services
                .AddScoped<IExternalApiClient, ApiFootballClient>()
                .AddScoped<ITeamsRepository, TeamsRepository>()
                .AddScoped<IPlayersRepository, PlayersRepository>()
                .AddScoped<ITeamsService, TeamsService>()
                .AddScoped<IPlayersService, PlayersService>();

            return services;
        }
    }
}
