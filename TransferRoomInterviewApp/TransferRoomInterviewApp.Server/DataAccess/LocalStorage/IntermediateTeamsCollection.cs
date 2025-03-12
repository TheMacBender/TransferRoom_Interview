namespace TransferRoomInterviewApp.Server.DataAccess.LocalStorage
{
    public class IntermediateTeamData
    {
        public int Id { get; set; }

        public string Name { get; set; } = "";

        public string NickName { get; set; } = "";
    }

    public class IntermediateTeamsCollection
    {
        private IReadOnlyList<IntermediateTeamData> _intermediateTeamData = new List<IntermediateTeamData>()
        {
             new IntermediateTeamData()
             {
                    Id = 42,
                    Name = "Arsenal",
                    NickName = "The Gunners"
             },new IntermediateTeamData()
             {
                    Id = 66,
                    Name = "Aston Villa",
                    NickName = "The Villans"
             },new IntermediateTeamData()
             {
                    Id = 35,
                    Name = "Bournemouth",
                    NickName = "The Cherries"
             },new IntermediateTeamData()
             {
                    Id = 55,
                    Name = "Brentford",
                    NickName = "The Bees"
             },new IntermediateTeamData()
             {
                    Id = 51,
                    Name = "Brighton & Hove Albion",
                    NickName = "The Albion"
             },new IntermediateTeamData()
             {
                    Id = 49,
                    Name = "Chelsea",
                    NickName = "The Blues"
             },new IntermediateTeamData()
             {
                    Id = 52,
                    Name = "Crystal Palace",
                    NickName = "The Eagles"
             },new IntermediateTeamData()
             {
                    Id = 45,
                    Name = "Everton",
                    NickName = "The Toffees"
             },new IntermediateTeamData()
             {
                    Id = 36,
                    Name = "Fulham",
                    NickName = "The Cottagers"
             },new IntermediateTeamData()
             {
                    Id = 57,
                    Name = "Ipswich Town",
                    NickName = "The Tractor Boys"
             },new IntermediateTeamData()
             {
                    Id = 46,
                    Name = "Leicester City",
                    NickName = "The Foxes"
             },new IntermediateTeamData()
             {
                    Id = 40,
                    Name = "Liverpool",
                    NickName = "The Reds"
             },new IntermediateTeamData()
             {
                    Id = 50,
                    Name = "Manchester City",
                    NickName = "The Citizens"
             },new IntermediateTeamData()
             {
                    Id = 33,
                    Name = "Manchester United",
                    NickName = "The Red Devils"
             },new IntermediateTeamData()
             {
                    Id = 34,
                    Name = "Newcastle United",
                    NickName = "The Magpies"
             },new IntermediateTeamData()
             {
                    Id = 65,
                    Name = "Nottingham Forest",
                    NickName = "The Garibaldis"
             },new IntermediateTeamData()
             {
                    Id = 41,
                    Name = "Southampton",
                    NickName = "The Saints"
             },new IntermediateTeamData()
             {
                    Id = 47,
                    Name = "Tottenham Hotspur",
                    NickName = "The Lilywhites"
             },new IntermediateTeamData()
             {
                    Id = 48,
                    Name = "West Ham United",
                    NickName = "The Hammers"
             },new IntermediateTeamData()
             {
                    Id = 39,
                    Name = "Wolverhampton Wanderers",
                    NickName = "Wolves"
             },
        };

        public IEnumerable<IntermediateTeamData> GetTeamsBySearchInput(string searchInput)
        {
            if (string.IsNullOrWhiteSpace(searchInput))
            {
                return Enumerable.Empty<IntermediateTeamData>();
            }

            return _intermediateTeamData
                .Where(data =>
                {
                    return data.Name.Contains(searchInput, StringComparison.CurrentCultureIgnoreCase) || data.NickName.Contains(searchInput, StringComparison.CurrentCultureIgnoreCase);
                });
        }
    }
}
