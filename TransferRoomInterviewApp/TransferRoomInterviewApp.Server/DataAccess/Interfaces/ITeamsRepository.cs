using TransferRoomInterviewApp.Server.Domain;

namespace TransferRoomInterviewApp.Server.DataAccess.Interfaces
{
    public interface ITeamsRepository
    {
        Task<IEnumerable<Team>> GetTeamsBySearchInputAsync(string searchInput);

        Task<Team?> GetTeamByTeamIdAsync(int teamId);
    }
}
