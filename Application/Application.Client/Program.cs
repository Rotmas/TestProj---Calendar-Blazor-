using Application.Client.Classes;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System.Net.Http;
using System.Threading.Tasks;

namespace Application.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services
                .AddSingleton<HttpClient>()
                .AddSingleton<Event>()
                .AddSingleton<Dates>();

            await builder.Build().RunAsync();
        }
    }
}
