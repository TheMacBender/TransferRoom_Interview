using TransferRoomInterviewApp.Server.Domain;

namespace TransferRoomInterviewApp.Server.DataAccess.Interfaces
{
    public interface ITeamsRepository
    {
        IEnumerable<Team> GetTeamsBySearchInput(string searchInput);

        Team? GetTeamByTeamId(int teamId);
    }
}
