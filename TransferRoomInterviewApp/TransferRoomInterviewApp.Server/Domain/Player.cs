namespace TransferRoomInterviewApp.Server.Domain
{
    public class Player
    {
        public int Id { get; set; }

        public int TeamId { get; set; }

        public string FirstName { get; set; } = "";

        public string LastName { get; set; } = "";

        public int Age { get; set; }

        public string PlayerPosition { get; set; } = "";

        public string ProfilePictureUrl { get; set; } = "";
    }
}
