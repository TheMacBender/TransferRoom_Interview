using TransferRoomInterviewApp.Server.BusinessLogic.Services;
using TransferRoomInterviewApp.Server.BusinessLogic.Services.Interfaces;
using TransferRoomInterviewApp.Server.DataAccess;
using TransferRoomInterviewApp.Server.DataAccess.Interfaces;

namespace TransferRoomInterviewApp.Server
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection ConfigureDependencies(this IServiceCollection services)
        {
            services
                .AddScoped<ITeamsRepository, TeamsRepository>()
                .AddScoped<ITeamsService, TeamsService>();

            return services;
        }
    }
}
