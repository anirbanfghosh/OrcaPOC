using POC.API.Services;
using POC.Domain.Interfaces;
using POC.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddSingleton<IContractService, ContractService>();
builder.Services.AddSingleton<IContractRepository, ContractRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
