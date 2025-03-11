using TransferRoomInterviewApp.Server.Infrastructure.Interfaces;
using TransferRoomInterviewApp.Server.Infrastructure.LocalStorage;
using TransferRoomInterviewApp.Server.Infrastructure.Models;

namespace TransferRoomInterviewApp.Server.Infrastructure
{
    public class ApiFootballClient : IExternalApiClient
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ApiFootballClient(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        private async Task<ExternalApiResponse<T>> GetAsync<T>(string url)
        {
            var apiClient = _httpClientFactory.CreateClient("Api-Football");
            var response = await apiClient.GetFromJsonAsync<ExternalApiResponse<T>>($"{url}");
            return response;
        }

        public async Task<ExternalApiResponse<TeamsResponseObject>> GetTeamByIdAsync(int teamId)
        {
            var teamData = await GetAsync<TeamsResponseObject>($"teams?id={teamId}");
            return teamData;
        }

        public async Task<ExternalApiResponse<PlayersResponseObject>> GetPlayersByTeamId(int teamId)
        {
            var playersData = await GetAsync<PlayersResponseObject>($"players/squads?team={teamId}");
            return playersData;
        }

        public Task<ExternalApiResponse<TeamsResponseObject>> GetTeamsBySearchInputAsync(string searchInput)
        {
            var teamsBySearchInput = IntermediateTeamsCollection.GetTeamsBySearchInput(searchInput);

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
