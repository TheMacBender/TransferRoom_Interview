using TransferRoomInterviewApp.Server.Domain;

namespace TransferRoomInterviewApp.Server.DataAccess.Interfaces
{
    public interface IPlayersRepository
    {
        IEnumerable<Player> GetPlayersByTeamId(int teamId);
    }
}
