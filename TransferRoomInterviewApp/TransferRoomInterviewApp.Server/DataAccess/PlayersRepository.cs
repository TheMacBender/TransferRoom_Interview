using TransferRoomInterviewApp.Server.DataAccess.Interfaces;
using TransferRoomInterviewApp.Server.Domain;
using TransferRoomInterviewApp.Server.Infrastructure.Interfaces;

namespace TransferRoomInterviewApp.Server.DataAccess
{
    public class PlayersRepository : IPlayersRepository
    {
        private readonly IExternalApiClient _externalApiClient;

        public PlayersRepository(IExternalApiClient externalApiClient)
        {
            _externalApiClient = externalApiClient;
        }

        public async Task<IEnumerable<Player>> GetPlayersByTeamIdAsync(int teamId)
        {
            return (await _externalApiClient.GetPlayersByTeamId(teamId))
                .Response
                .FirstOrDefault()
                .Players
                .Select(player => new Player
                {
                    Id = player.Id,
                    TeamId = teamId,
                    FirstName = player.Name,
                    PlayerPosition = player.Position,
                    ProfilePictureUrl = player.Photo
                });
        }
    }
}
