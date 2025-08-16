var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

// Replace placeholder with actual secret
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
connectionString = connectionString.Replace("${DATABASE_URL}", Environment.GetEnvironmentVariable("DATABASE_URL"));
builder.Configuration["ConnectionStrings:DefaultConnection"] = connectionString;

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.Run();
