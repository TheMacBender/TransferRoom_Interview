namespace TransferRoomInterviewApp.Server.Infrastructure.Models
{
    public class ExternalApiResponse<T>
    {
        public int Results { get; set; }
        public IEnumerable<T> Response { get; set; }
    }
}
