using Microsoft.OpenApi.Models;
using POC.Dapper.ToDoApi.Domain;
using System.Data.SqlClient;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient(_ => new SqlConnection(builder.Configuration.GetConnectionString("SQLConnectionString")));
builder.Services.AddScoped<TodoService>();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options => {
    options.SwaggerDoc("v1", new OpenApiInfo {
        Version = "v1",
        Title = "POC Dapper To Do API"
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options => {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
