using TransferRoomInterviewApp.Server.Domain;

namespace TransferRoomInterviewApp.Server.BusinessLogic.Services.Interfaces
{
    public interface IPlayersService
    {
        IEnumerable<Player> GetPlayersByTeamId(int teamId);
    }
}
