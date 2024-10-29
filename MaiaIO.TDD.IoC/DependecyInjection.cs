using MaiaIO.TDD.API.Services.Factories;
using MaiaIO.TDD.API.Services.Factories.Interfaces;
using MaiaIO.TDD.API.Services.Machines;
using MaiaIO.TDD.API.Services.Machines.Interfaces;
using MaiaIO.TDD.Aplication.Services.ProductionLines;
using MaiaIO.TDD.Aplication.Services.ProductionLines.Interfaces;
using MaiaIO.TDD.Domain.Factories.Repositories.Interfaces;
using MaiaIO.TDD.Domain.Factories.Services;
using MaiaIO.TDD.Domain.Factories.Services.Interface;
using MaiaIO.TDD.Domain.Machines.Repositories.Interfaces;
using MaiaIO.TDD.Domain.ProductionLines.Repositories;
using MaiaIO.TDD.Infra.Factories.Repositories;
using MaiaIO.TDD.Infra.Machines.Repositories;
using MaiaIO.TDD.Infra.ProductionLines.Repositories;
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

            services.AddScoped<IProductionLineAppService, ProductionLineAppService>();
            //services.AddScoped<IProductionLineService, FactoryService>();
            services.AddScoped<IProductionLineRepository, ProductionLineRepository>();

            services.AddScoped<IMachineAppService, MachineAppService>();
            //services.AddScoped<IMachineService, FactoryService>();
            services.AddScoped<IMachineRepository, MachineRepository>();


            return services;

        }
    }
}
