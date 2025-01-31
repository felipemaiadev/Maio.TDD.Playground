// See https://aka.ms/new-console-template for more information


using MaiaIO.TDD.CLI;
using MaiaIO.TDD.Domain.Devices.Entities;
using MaiaIO.TDD.Domain.Devices.Enums;
using MaiaIO.TDD.Domain.Factories.Entities;
using MaiaIO.TDD.Domain.Machines.Commands;
using MaiaIO.TDD.Domain.Machines.Entities;
using MaiaIO.TDD.Domain.ProductionLines.Commands;
using MaiaIO.TDD.Domain.ProductionLines.Entities;
using MaiaIO.TDD.Infra;
using NHibernate.Linq;
using System.Reflection.PortableExecutable;

var busca = new FabricaListarRequest { Id = 0, Name = "", IsActive = true, 
                                       Country = "BRAZIL", VendorType = TypeDeviceEnum.PLC ,
                                       LineStatus = true };
var service = new FabricaAppService();

//FactoryAppService.GetCriterios(busca);

var pms = FabricaAppService.BuildParser(busca);
var instanceBusca = FabricaAppService.CriterioSelect("BuscarComLinhasAtivas");

pms.Add("OPR", ">=");

var predicate = instanceBusca.Buscar(pms);

DbContext.Initialize();

var factory = DbContext.sessionFactory;

var session = factory.OpenSession();

session.CreateCriteria<BaseMachine>().SetFetchMode("DeviceList", NHibernate.FetchMode.Eager);

if (session != null)
{

    //var result = session.Query<Factory>()
    //                    .Where(predicate)
    //                    .ToList();

    var result = session.Query<BaseMachine>()
                            .Fetch(x => x.ProductionLine)
                            .Fetch(x => x.DeviceList)
                            .SelectMany(x => x.DeviceList, (machine, device) => new BaseMachineListarComando
                            {
                                Id = machine.Id,
                                ProductionLineName = machine.ProductionLine.Name,
                                DeviceName = device.Description
                            })
                            .Where(x => x.Id > 0 )
                            .ToList();

    var lineReport  = session.Query<ProductionLine>()
                           .Fetch(x => x.Machines)
                           .SelectMany(x => x.Machines, (line, machine) => new ProductionLineListCommand
                           {
                               UIDProdutionLine = line.UID,
                               ProductionLineName = machine.ProductionLine.Name,
                               MachineName =  machine.Name,
                               MachineInvetoryCode = machine.InventoryCode
                           })
                           .ToList();


    //foreach (var row in result)
    //    Console.WriteLine($"{row.Name} - {row.Description} - {row.AssemblyStamp} - {row.Lines.FirstOrDefault().Machines.FirstOrDefault()}");


    foreach (var row in result)
        Console.WriteLine($"{row.Id} - {row.ProductionLineName}");

}
