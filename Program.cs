using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Http.Json;
using SimplyBooks.Endpoints;

var builder = WebApplication.CreateBuilder(args);

// add services to the container
// learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// allows API endpoints to access the database through Entity Framework Core
builder.Services.AddNpgsql<SimplyBooksDbContext>(builder.Configuration["SimplyBooksDbConnectionString"]);

// set the JSON serializer options
builder.Services.Configure<JsonOptions>(options =>
{
    options.SerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
});

var app = builder.Build();

// configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// endpoints
AuthorEndpoints.Map(app);
BookEndpoints.Map(app);

app.Run();