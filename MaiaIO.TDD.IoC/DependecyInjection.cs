using MaiaIO.TDD.API.Services.Factories;
using MaiaIO.TDD.API.Services.Factories.Interfaces;
using MaiaIO.TDD.Domain.Factories.Repositories.Interfaces;
using MaiaIO.TDD.Domain.Factories.Services;
using MaiaIO.TDD.Domain.Factories.Services.Interface;
using MaiaIO.TDD.Infra.Factories.Repositories;
using Microsoft.Extensions.DependencyInjection;


namespace MaiaIO.TDD.IoC
{
    public static class DependecyInjection
    {

        public static IServiceCollection DIConfig(this IServiceCollection services)
        {

            services.AddScoped<IFactoryAppService, FactoryAppService>();
            services.AddScoped<IFactoryService, FactoryService>();
            services.AddScoped<IFactoryRepository, FactoryRepository>();

            return services;

        }
    }
}
