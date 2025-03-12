using TransferRoomInterviewApp.Server.DataAccess.Models;

namespace TransferRoomInterviewApp.Server.DataAccess
{
    public abstract class HttpClientBaseRepository
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public HttpClientBaseRepository(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        protected async Task<ExternalApiResponse<T>> GetAsync<T>(string url)
        {
            var apiClient = _httpClientFactory.CreateClient("Api-Football");
            var response = await apiClient.GetFromJsonAsync<ExternalApiResponse<T>>($"{url}");
            return response ?? new ExternalApiResponse<T>();
        }
    }
}
