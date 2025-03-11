namespace TransferRoomInterviewApp.Server.Domain
{
    public class Player
    {
        public int Id { get; set; }

        public int TeamId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        // Supposedly can be changed to enum?
        public string PlayerPosition { get; set; }

        public string ProfilePictureUrl { get; set; }
    }
}
