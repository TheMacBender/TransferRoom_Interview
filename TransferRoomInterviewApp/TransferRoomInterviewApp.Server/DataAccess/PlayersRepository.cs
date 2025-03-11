using TransferRoomInterviewApp.Server.DataAccess.Interfaces;
using TransferRoomInterviewApp.Server.DataAccess.Models;

namespace TransferRoomInterviewApp.Server.DataAccess
{
    public class PlayersRepository : HttpClientBaseRepository, IPlayersRepository
    {
        public PlayersRepository(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
        {
        }

        public async Task<ExternalApiResponse<PlayersResponseObject>> GetPlayersByTeamId(int teamId)
        {
            var playersData = await GetAsync<PlayersResponseObject>($"players/squads?team={teamId}");
            return playersData;
        }
    }
}
