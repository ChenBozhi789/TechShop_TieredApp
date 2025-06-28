using BlazorClientApp;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using RestApi.Client;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");

// ProductClient registration - Need to understand
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:5159/") });
builder.Services.AddScoped<IApiConfiguration, ApiConfiguration>();  
builder.Services.AddScoped<ProductClient>();
builder.Services.AddScoped<BrandClient>();
builder.Services.AddScoped<IProductClient, ProductClient>();

builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
