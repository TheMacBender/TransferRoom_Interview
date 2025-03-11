using TransferRoomInterviewApp.Server.Infrastructure.LocalStorage;
using TransferRoomInterviewApp.Server.Infrastructure.Models;

namespace TransferRoomInterviewApp.Server.Infrastructure.Interfaces
{
    public interface IExternalApiClient
    {
        Task<ExternalApiResponse<TeamsResponseObject>> GetTeamByIdAsync(int teamId);

        Task<ExternalApiResponse<TeamsResponseObject>> GetTeamsBySearchInputAsync(string searchInput);

        Task<ExternalApiResponse<PlayersResponseObject>> GetPlayersByTeamId(int teamId);
    }
}
