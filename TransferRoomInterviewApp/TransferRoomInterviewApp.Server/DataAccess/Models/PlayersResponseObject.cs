namespace TransferRoomInterviewApp.Server.DataAccess.Models
{
    public class PlayersResponseObject
    {
        public TeamObject Team { get; set; }
        public IEnumerable<PlayerObject> Players { get; set; }
    }
}
