using TransferRoomInterviewApp.Server.DataAccess.Interfaces;
using TransferRoomInterviewApp.Server.Domain;

namespace TransferRoomInterviewApp.Server.DataAccess
{
    public class TeamsRepository : ITeamsRepository
    {
        private IReadOnlyList<Team> _teams;

        public TeamsRepository()
        {
            _teams = new List<Team>()
            {
                new Team()
                {
                    Id = 1,
                    Name = "Liverpool",
                    Nickname = "The Reds",
                    BadgeUrl = ""
                },
                new Team()
                {
                    Id = 2,
                    Name = "Leicester",
                    Nickname = "The Foxes",
                    BadgeUrl = ""
                }
            };
        }

        public IEnumerable<Team> GetTeamsBySearchInput(string searchInput)
        {
            if (searchInput == "")
            {
                return Enumerable.Empty<Team>();
            }

            return _teams
                .Where(t => t.Name.Contains(searchInput) || t.Nickname.Contains(searchInput));
        }

        public Team? GetTeamByTeamId(int teamId)
        {
            return _teams.FirstOrDefault(t => t.Id == teamId);
        }
    }
}
