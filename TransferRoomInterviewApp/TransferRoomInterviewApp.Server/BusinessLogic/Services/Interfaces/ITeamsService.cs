using TransferRoomInterviewApp.Server.Domain;

namespace TransferRoomInterviewApp.Server.BusinessLogic.Services.Interfaces
{
    public interface ITeamsService
    {
        IEnumerable<Team> GetTeamsBySearchInput(string searchInput);

        Team GetTeamByTeamId(int teamId);
    }
}
