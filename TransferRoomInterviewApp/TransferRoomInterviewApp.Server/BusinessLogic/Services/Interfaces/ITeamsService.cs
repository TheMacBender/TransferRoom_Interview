using TransferRoomInterviewApp.Server.Domain;

namespace TransferRoomInterviewApp.Server.BusinessLogic.Services.Interfaces
{
    public interface ITeamsService
    {
        Task<IEnumerable<Team>> GetTeamsBySearchInputAsync(string searchInput);

        Task<Team?> GetTeamByTeamIdAsync(int teamId);
    }
}
