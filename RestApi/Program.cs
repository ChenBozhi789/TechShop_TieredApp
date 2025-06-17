using DataAccessLayer;
using BusinessLayer;

var builder = WebApplication.CreateBuilder(args);

// AutoMapper registration
builder.Services.AddAutoMapper(typeof(MappingProfile));

// Add services to the container.
builder.Services.RegisterDbContext(builder.Configuration.GetConnectionString("Connection"));
builder.Services.RegisterServices(); // Business Layer
builder.Services.RegisterRepositories(); // Data Access Layer
builder.Services.AddControllers().AddNewtonsoftJson(options =>
{
    options.SerializerSettings.TypeNameHandling = Newtonsoft.Json.TypeNameHandling.Auto;
    options.SerializerSettings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
});

// Add CORS policy
builder.Services.AddCors(p => p.AddPolicy("corsapp", builder =>
{
    builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
}));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("corsapp");

app.UseAuthorization();

app.MapControllers();

app.Run();
