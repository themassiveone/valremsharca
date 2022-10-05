using U.Providers.ServiceIdentity;
using U.Providers.Proxying;
using U.Implementations.Resources;
using U.Types.Components;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddSingleton<ProxyBase, Proxying>();
builder.Services.AddSingleton<IStore, ResourceStore>();
builder.Services.AddSingleton<IServiceIdentity, ServiceIdentity>();

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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
