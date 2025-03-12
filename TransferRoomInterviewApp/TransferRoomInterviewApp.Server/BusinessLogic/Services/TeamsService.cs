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

        public async Task<IEnumerable<Team>> GetTeamsBySearchInputAsync(string searchInput)
        {
            if (searchInput == "")
            {
                return Enumerable.Empty<Team>();
            }

            return (await _teamsRepository.GetTeamsBySearchInputAsync(searchInput))
                .Response
                .Select(data => new Team
                {
                    Id = data.Team?.Id ?? 0,
                    Name = data.Team?.Name ?? "",
                    BadgeUrl = "",
                });
        }

        public async Task<Team?> GetTeamByTeamIdAsync(int teamId)
        {
            return (await _teamsRepository.GetTeamByIdAsync(teamId))
                .Response
                .Select(data => new Team
                {
                    Id = data.Team?.Id ?? 0,
                    Name = data.Team?.Name ?? "",
                    BadgeUrl = data.Team?.Logo ?? ""
                }).FirstOrDefault();
        }
    }
}
