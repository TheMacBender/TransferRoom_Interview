using TransferRoomInterviewApp.Server.DataAccess.Interfaces;
using TransferRoomInterviewApp.Server.Domain;
using TransferRoomInterviewApp.Server.Infrastructure.Interfaces;

namespace TransferRoomInterviewApp.Server.DataAccess
{
    public class TeamsRepository : ITeamsRepository
    {
        private readonly IExternalApiClient _externalApiClient;

        public TeamsRepository(IExternalApiClient externalApiClient)
        {
            _externalApiClient = externalApiClient;
        }

        public async Task<IEnumerable<Team>> GetTeamsBySearchInputAsync(string searchInput)
        {
            if (searchInput == "")
            {
                return Enumerable.Empty<Team>();
            }

            return (await _externalApiClient.GetTeamsBySearchInputAsync(searchInput))
                .Response
                .Select(data => new Team
                 {
                     Id = data.Team.Id,
                     Name = data.Team.Name,
                     BadgeUrl = "",
                 });
        }

        public async Task<Team?> GetTeamByTeamIdAsync(int teamId)
        {
            return (await _externalApiClient.GetTeamByIdAsync(teamId))
                .Response
                .Select(data => new Team
                {
                    Id = data.Team.Id,
                    Name = data.Team.Name,
                    BadgeUrl = data.Team.Logo
                }).FirstOrDefault();
        }
    }
}
