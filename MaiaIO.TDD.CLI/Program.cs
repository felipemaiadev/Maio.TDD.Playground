// See https://aka.ms/new-console-template for more information


using MaiaIO.TDD.CLI;
using MaiaIO.TDD.Domain.Factories.Entities;
using MaiaIO.TDD.Infra;

var busca = new FactoryListarRequest { Id= 0,Name= "", IsActive=true, Country="BRAZIL" };
var service = new FactoryAppService();

//FactoryAppService.GetCriterios(busca);

var pms =  FactoryAppService.BuildParser(busca);
var instanceBusca = FactoryAppService.CriterioSelect("BuscarPorId");

pms.Add("OPR", ">=");

var predicate = instanceBusca.Buscar(pms);
                                                                                    
DbContext.Initialize();

var factory = DbContext.sessionFactory;

var session = factory.OpenSession();

if (session != null)
{

    var result = session.Query<Factory>()
                        .Where(predicate)
                        .ToList();

    foreach (var row in result)
        Console.WriteLine($"{row.Name} - {row.Description} - {row.AssemblyStamp}");

}
