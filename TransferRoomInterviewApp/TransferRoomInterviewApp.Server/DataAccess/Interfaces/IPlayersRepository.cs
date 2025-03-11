using TransferRoomInterviewApp.Server.DataAccess.Models;
using TransferRoomInterviewApp.Server.Domain;

namespace TransferRoomInterviewApp.Server.DataAccess.Interfaces
{
    public interface IPlayersRepository
    {
        Task<ExternalApiResponse<PlayersResponseObject>> GetPlayersByTeamId(int teamId);
    }
}
