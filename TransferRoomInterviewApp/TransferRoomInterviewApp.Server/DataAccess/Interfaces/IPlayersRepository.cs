using TransferRoomInterviewApp.Server.Domain;

namespace TransferRoomInterviewApp.Server.DataAccess.Interfaces
{
    public interface IPlayersRepository
    {
        Task<IEnumerable<Player>> GetPlayersByTeamIdAsync(int teamId);
    }
}
