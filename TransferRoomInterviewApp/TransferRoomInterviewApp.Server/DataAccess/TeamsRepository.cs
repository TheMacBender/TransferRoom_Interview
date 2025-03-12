using TransferRoomInterviewApp.Server.DataAccess.Interfaces;
using TransferRoomInterviewApp.Server.DataAccess.LocalStorage;
using TransferRoomInterviewApp.Server.DataAccess.Models;

namespace TransferRoomInterviewApp.Server.DataAccess
{
    public class TeamsRepository : HttpClientBaseRepository, ITeamsRepository
    {
        private readonly IntermediateTeamsCollection _teamsCollection;

        public TeamsRepository(IHttpClientFactory httpClientFactory, IntermediateTeamsCollection teamsCollection) : base(httpClientFactory)
        {
            _teamsCollection = teamsCollection;
        }

        public async Task<ExternalApiResponse<TeamsResponseObject>> GetTeamByIdAsync(int teamId)
        {
            var teamData = await GetAsync<TeamsResponseObject>($"teams?id={teamId}");
            return teamData;
        }

        public Task<ExternalApiResponse<TeamsResponseObject>> GetTeamsBySearchInputAsync(string searchInput)
        {
            var teamsBySearchInput = _teamsCollection.GetTeamsBySearchInput(searchInput);

            if (!teamsBySearchInput.Any())
            {
                return Task.FromResult(new ExternalApiResponse<TeamsResponseObject>()
                {
                    Results = 0,
                    Response = Enumerable.Empty<TeamsResponseObject>()
                });
            }

            return Task.FromResult(new ExternalApiResponse<TeamsResponseObject>()
            {
                Results = teamsBySearchInput.Count(),
                Response = teamsBySearchInput.Select(team => new TeamsResponseObject
                {
                    Team = new TeamObject
                    {
                        Id = team.Id,
                        Name = team.Name,
                    }
                })
            });
        }
    }
}
