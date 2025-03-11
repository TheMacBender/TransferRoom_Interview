using TransferRoomInterviewApp.Server.BusinessLogic.Services.Interfaces;
using TransferRoomInterviewApp.Server.DataAccess.Interfaces;
using TransferRoomInterviewApp.Server.Domain;

namespace TransferRoomInterviewApp.Server.BusinessLogic.Services
{
    public class TeamsService : ITeamsService
    {
        private readonly ITeamsRepository _teamsRepository;

        public TeamsService(ITeamsRepository teamsRepository)
        {
            _teamsRepository = teamsRepository;
        }

        public Task<IEnumerable<Team>> GetTeamsBySearchInputAsync(string searchInput)
        {
            return _teamsRepository.GetTeamsBySearchInputAsync(searchInput);
        }

        public Task<Team?> GetTeamByTeamIdAsync(int teamId)
        {
            return _teamsRepository.GetTeamByTeamIdAsync(teamId);
        }
    }
}
