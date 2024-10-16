// See https://aka.ms/new-console-template for more information


using MaiaIO.TDD.CLI;
using MaiaIO.TDD.Domain.Devices.Entities;
using MaiaIO.TDD.Domain.Devices.Enums;
using MaiaIO.TDD.Domain.Factories.Entities;
using MaiaIO.TDD.Domain.Machines.Entities;
using MaiaIO.TDD.Infra;
using NHibernate.Linq;
using System.Reflection.PortableExecutable;

var busca = new FactoryListarRequest { Id = 0, Name = "", IsActive = true, 
                                       Country = "BRAZIL", VendorType = TypeDeviceEnum.PLC ,
                                       LineStatus = true };
var service = new FactoryAppService();

//FactoryAppService.GetCriterios(busca);

var pms = FactoryAppService.BuildParser(busca);
var instanceBusca = FactoryAppService.CriterioSelect("BuscarComLinhasAtivas");

pms.Add("OPR", ">=");

var predicate = instanceBusca.Buscar(pms);

DbContext.Initialize();

var factory = DbContext.sessionFactory;

var session = factory.OpenSession();

session.CreateCriteria<BaseMachine>().SetFetchMode("DeviceList", NHibernate.FetchMode.Eager);

if (session != null)
{

    var result = session.Query<Factory>()
                        .Where(predicate)
                        .ToList();

    //var result = session.Query<BaseMachine>()
    //                        //.Fetch(x => x.DeviceList)
    //                        .Where(x => x.Id == 1)
    //                        .ToList();

    foreach (var row in result)
        Console.WriteLine($"{row.Name} - {row.Description} - {row.AssemblyStamp} - {row.Lines.FirstOrDefault().Machines.FirstOrDefault()}");


    //foreach (var row in result)
    //    Console.WriteLine($"{row.UID} - {row.ProductionLine}");

}
