using TransferRoomInterviewApp.Server.BusinessLogic.Services;
using TransferRoomInterviewApp.Server.BusinessLogic.Services.Interfaces;
using TransferRoomInterviewApp.Server.DataAccess;
using TransferRoomInterviewApp.Server.DataAccess.Interfaces;
using TransferRoomInterviewApp.Server.DataAccess.LocalStorage;

namespace TransferRoomInterviewApp.Server
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection ConfigureDependencies(this IServiceCollection services)
        {
            services
                .AddSingleton(typeof(IntermediateTeamsCollection))
                .AddScoped<ITeamsRepository, TeamsRepository>()
                .AddScoped<IPlayersRepository, PlayersRepository>()
                .AddScoped<ITeamsService, TeamsService>()
                .AddScoped<IPlayersService, PlayersService>();

            return services;
        }
    }
}
