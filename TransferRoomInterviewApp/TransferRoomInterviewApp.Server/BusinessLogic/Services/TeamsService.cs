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

        public IEnumerable<Team> GetTeamsBySearchInput(string searchInput)
        {
            return _teamsRepository.GetTeamsBySearchInput(searchInput);
        }

        public Team? GetTeamByTeamId(int teamId)
        {
            return _teamsRepository.GetTeamByTeamId(teamId);
        }
    }
}
