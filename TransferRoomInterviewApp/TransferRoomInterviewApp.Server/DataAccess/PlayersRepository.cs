using TransferRoomInterviewApp.Server.DataAccess.Interfaces;
using TransferRoomInterviewApp.Server.Domain;

namespace TransferRoomInterviewApp.Server.DataAccess
{
    public class PlayersRepository : IPlayersRepository
    {
        private IReadOnlyList<Player> _players = new List<Player>()
        {
            new Player()
            {
                Id = 1,
                TeamId = 1,
                FirstName = "Mohamed",
                LastName = "Salah",
                PlayerPosition = "FW",
                BirthDate = DateTime.Now,
                ProfilePictureUrl = ""
            },
            new Player()
            {
                Id = 2,
                TeamId = 2,
                FirstName = "Jamie",
                LastName = "Vardy",
                PlayerPosition = "FW",
                BirthDate = DateTime.Now,
                ProfilePictureUrl = ""
            }
        };

        public IEnumerable<Player> GetPlayersByTeamId(int teamId)
        {
            return _players
                .Where(p => p.TeamId == teamId);
        }
    }
}
