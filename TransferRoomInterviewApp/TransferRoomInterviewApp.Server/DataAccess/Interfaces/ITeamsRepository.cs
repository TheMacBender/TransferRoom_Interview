using TransferRoomInterviewApp.Server.DataAccess.Models;
using TransferRoomInterviewApp.Server.Domain;

namespace TransferRoomInterviewApp.Server.DataAccess.Interfaces
{
    public interface ITeamsRepository
    {
        Task<ExternalApiResponse<TeamsResponseObject>> GetTeamByIdAsync(int teamId);

        Task<ExternalApiResponse<TeamsResponseObject>> GetTeamsBySearchInputAsync(string searchInput);
    }
}
