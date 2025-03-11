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

        public IEnumerable<Player> GetPlayersByTeamId(int teamId)
        {
            return _playersRepository.GetPlayersByTeamId(teamId);
        }
    }
}
