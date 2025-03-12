
using System.Reflection;
using TransferRoomInterviewApp.Server.Configuration;

namespace TransferRoomInterviewApp.Server
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.ConfigureDependencies();

            var externalApiHost = builder.Configuration.GetValue<string>($"{nameof(ExternalApiConfiguration)}:{nameof(ExternalApiConfiguration.Host)}") ?? "";
            var externalApiKey = builder.Configuration.GetValue<string>($"{nameof(ExternalApiConfiguration)}:{nameof(ExternalApiConfiguration.ApiKey)}") ?? "";

            builder.Services.AddHttpClient("Api-Football", httpClient =>
            {
                httpClient.BaseAddress = new Uri(externalApiHost);
                httpClient.DefaultRequestHeaders.Add(
                    "x-apisports-key", externalApiKey);
            });

            builder.Services.AddControllers();

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(options =>
            {
                var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
            });

            var app = builder.Build();

            app.UseDefaultFiles();
            app.UseStaticFiles();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.MapFallbackToFile("/index.html");

            app.Run();
        }
    }
}
