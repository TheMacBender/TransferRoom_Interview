using TransferRoomInterviewApp.Server.BusinessLogic.Services.Interfaces;
using TransferRoomInterviewApp.Server.DataAccess.Interfaces;
using TransferRoomInterviewApp.Server.Domain;

namespace TransferRoomInterviewApp.Server.BusinessLogic.Services
{
    public class PlayersService : IPlayersService
    {
        private readonly IPlayersRepository _playersRepository;

        public PlayersService(IPlayersRepository playersRepository)
        {
            _playersRepository = playersRepository;
        }

        public async Task<IEnumerable<Player>> GetPlayersByTeamIdAsync(int teamId)
        {
            return (await _playersRepository.GetPlayersByTeamId(teamId))
                .Response
                .FirstOrDefault()
                .Players
                .Select(player => new Player
                {
                    Id = player.Id,
                    TeamId = teamId,
                    FirstName = player.Name,
                    PlayerPosition = player.Position,
                    Age = player.Age,
                    ProfilePictureUrl = player.Photo
                });
        }
    }
}
