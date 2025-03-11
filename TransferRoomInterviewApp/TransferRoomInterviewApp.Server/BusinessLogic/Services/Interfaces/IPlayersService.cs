using TransferRoomInterviewApp.Server.Domain;

namespace TransferRoomInterviewApp.Server.BusinessLogic.Services.Interfaces
{
    public interface IPlayersService
    {
        Task<IEnumerable<Player>> GetPlayersByTeamIdAsync(int teamId);
    }
}
