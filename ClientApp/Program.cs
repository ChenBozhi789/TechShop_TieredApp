using BusinessLayer;
using DataAccessLayer;
using Microsoft.Extensions.Options;
using RestApi.Client;

var builder = WebApplication.CreateBuilder(args);

// Registration
builder.Services.Configure<ApiConfiguration>(
    builder.Configuration.GetSection("ApiConfiguration"));
builder.Services.AddSingleton<IApiConfiguration>(sp =>
    sp.GetRequiredService<IOptions<ApiConfiguration>>().Value);

// Add services to the container.
builder.Services.RegisterClients();
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();