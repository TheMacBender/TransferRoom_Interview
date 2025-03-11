
using TransferRoomInterviewApp.Server.Configuration;

namespace TransferRoomInterviewApp.Server
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.ConfigureDependencies();

            var externalApiHost = builder.Configuration.GetValue<string>($"{nameof(ExternalApiConfiguration)}:{nameof(ExternalApiConfiguration.Host)}") ?? "";
            var externalApiKey = builder.Configuration.GetValue<string>($"{nameof(ExternalApiConfiguration)}:{nameof(ExternalApiConfiguration.ApiKey)}") ?? "";

            builder.Services.AddHttpClient("Api-Football", httpClient =>
            {
                // Read from appsettings?
                httpClient.BaseAddress = new Uri(externalApiHost);
                httpClient.DefaultRequestHeaders.Add(
                    "x-apisports-key", externalApiKey);
            });

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            app.UseDefaultFiles();
            app.UseStaticFiles();

            // Configure the HTTP request pipeline.
            //if (app.Environment.IsDevelopment())
            //{
            app.UseSwagger();
            app.UseSwaggerUI();
            //}

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.MapFallbackToFile("/index.html");

            app.Run();
        }
    }
}
