namespace TransferRoomInterviewApp.Server.Domain
{
    public class Team
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Nickname { get; set; }

        public IEnumerable<Player> Players { get; set; }
    }
}
