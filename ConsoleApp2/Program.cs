using ConsoleApp2;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using RestApi.Client;
using System.IO;

var builder = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

var configuration = builder.Build();
Console.WriteLine("API Url from config: " + configuration["ApiConfiguration:Url"]);

var serviceProvider = new ServiceCollection()
    .Configure<ApiConfiguration>(configuration.GetSection("ApiConfiguration"))
    .AddSingleton<IApiConfiguration>(x => x.GetRequiredService<IOptions<ApiConfiguration>>().Value)
    .AddSingleton<IConsoleApplication, ConsoleApplication>()
    .RegisterClients()
    .BuildServiceProvider();

IServiceScope scope = serviceProvider.CreateScope();
scope.ServiceProvider.GetRequiredService<IConsoleApplication>().Run();

if (serviceProvider is IDisposable)
{
    serviceProvider.Dispose();
}