using MaiaIO.TDD.API.DTO.Factories.Profiles;
using MaiaIO.TDD.API.Services.Factories;
using MaiaIO.TDD.API.Services.Factories.Interfaces;
using MaiaIO.TDD.Domain.Factories.Repositories.Interfaces;
using MaiaIO.TDD.Domain.Factories.Services;
using MaiaIO.TDD.Domain.Factories.Services.Interface;
using MaiaIO.TDD.Infra.Factories.Repositories;
using MaiaIO.TDD.IoC;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "FTW-API", Version = "v1" });
    c.CustomSchemaIds(x => x.FullName);
});

var section = builder.Configuration.GetSection("ConnectionString");

builder.Services.AddNHibernate(section.Value);

builder.Services.AddAutoMapper(typeof(FactoryProfile).Assembly);

//builder.Services.AddSingleton<IMapper>();

//builder.Services.AddScoped<IFactoryAppService, FactoryAppService>();
//builder.Services.AddScoped<IFactoryService, FactoryService>();
//builder.Services.AddScoped<IFactoryRepository, FactoryRepository>();

builder.Services.DIConfig();


builder.Services.AddMvc().AddJsonOptions(opt =>
{
    opt.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "v1 Docs");
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
