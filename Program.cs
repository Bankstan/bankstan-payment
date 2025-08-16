using bankstan_payment.Domain;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddDbContext<ApplicationDbContext>(o => { o.UseNpgsql(builder.Configuration["DefaultConnection"]!); }
);
builder.Services.AddDatabaseDeveloperPageExceptionFilter();
// Replace placeholder with actual secret

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();


app.MapGet("/", () => "Hello World!");

app.Run();