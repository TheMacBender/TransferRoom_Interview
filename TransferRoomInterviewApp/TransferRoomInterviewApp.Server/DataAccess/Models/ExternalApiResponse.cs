namespace TransferRoomInterviewApp.Server.DataAccess.Models
{
    public class ExternalApiResponse<T>
    {
        public int Results { get; set; }
        public IEnumerable<T> Response { get; set; } = new List<T>();
    }
}
