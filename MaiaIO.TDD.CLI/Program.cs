// See https://aka.ms/new-console-template for more information


using MaiaIO.TDD.Aplication.DTO.ProductionLines.Response;
using MaiaIO.TDD.CLI;
using MaiaIO.TDD.Domain.Devices.Entities;
using MaiaIO.TDD.Domain.Devices.Enums;
using MaiaIO.TDD.Domain.Machines.Entities;
using MaiaIO.TDD.Domain.ProductionLines.Entities;
using MaiaIO.TDD.Domain.WorkOrders.Entities;
using MaiaIO.TDD.Infra;
using NHibernate.Criterion;
using NHibernate.Transform;
using static MaiaIO.TDD.Domain.ProductionLines.Entities.ProductionLineWorkerOrder;

var busca = new FabricaListarRequest
{
    Id = 0,
    Name = "",
    IsActive = true,
    Country = "BRAZIL",
    VendorType = TypeDeviceEnum.PLC,
    LineStatus = true
};
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

    //var result = session.Query<BaseMachine>()
    //                        .Fetch(x => x.ProductionLine)
    //                        .Fetch(x => x.DeviceList)
    //                        .SelectMany(x => x.DeviceList, (machine, device) => new BaseMachineListarComando
    //                        {
    //                            Id = machine.Id,
    //                            ProductionLineName = machine.ProductionLine.Name,
    //                            DeviceName = device.Description
    //                        })
    //                        .Where(x => x.Id > 0 )
    //                        .ToList();

    var machine = new BaseMachine();
    var device = new BaseDevice();
    var line = new ProductionLine();
    var orders = new WorkOrder();

    //var resultReport = session.QueryOver(() => machine)
    //                          .JoinAlias(x => x.ProductionLine, () => line)
    //                          .JoinAlias(x => x.DeviceList, () => device).Where(() => device.Machines.Contains(machine))
    //                            .SelectList(list => list
    //                                 .Select(machine => machine.Id)
    //                                 .Select(line => line.Name)
    //                                 .Select(device => device.DeviceList.ToList()))
    //                          .List<object>();



    //var lineReport  = session.Query<ProductionLine>()
    //                       //.Fetch(x => x.Machines)
    //                       .SelectMany(x => x.Machines, (line, machine) => new ProductionLineListCommand
    //                       {
    //                           UIDProdutionLine = line.UID,
    //                           ProductionLineName = machine.ProductionLine.Name,
    //                           MachineName =  machine.Name,
    //                           MachineInvetoryCode = machine.InventoryCode
    //                       }).ToList();

    var lineReportNew = session.QueryOver(() => line)
                               .JoinAlias(x => x.Machines, () => machine)
                               .JoinAlias(x => x.WorkOrders, () => orders)
                               .Select(
                                    Projections.Property(() => line.Id).WithAlias("Id"),
                                    Projections.Property(() => machine.Name).WithAlias("MachineName"),
                                    Projections.Property(() => orders.OrderCode).WithAlias("OrderCode")
                               )
                               .TransformUsing(Transformers.AliasToBean<ProductionLineReportResponse>())
                               .OrderBy(x => x.Id)
                               .Asc
                               .List<ProductionLineReportResponse>();


    var plWorkOrder = ProductionLineWorkerOrderFactory.Create();

    var lineReportComplete = session.QueryOver(() => plWorkOrder)
                                    .JoinAlias(x => x.ProductionLines, () => line)
                                    .JoinAlias(x => x.WorkOrders, () => orders)
                                    .Select(
                                         Projections.Property(() => plWorkOrder.Id).WithAlias("IDPLWKORDER"),
                                         Projections.Property(() => plWorkOrder.IdProductionLine).WithAlias("IDPRODUCTIONLINE"),
                                         Projections.Property(() => line.Name).WithAlias("PLNAME"),
                                         Projections.Property(() => plWorkOrder.IdWorkerOrder).WithAlias("IDWKORDER"),
                                         Projections.Property(() => orders.OrderCode).WithAlias("WKORDERCODE"),
                                         Projections.Property(() => plWorkOrder.Status).WithAlias("STATUSPLWKORDER"),
                                         Projections.Property(() => plWorkOrder.CreateTimeStamp).WithAlias("CREATEPLWKORDER"))
                                    .List<object[]>();




    //foreach (var row in result)
    //    Console.WriteLine($"{row.Name} - {row.Description} - {row.AssemblyStamp} - {row.Lines.FirstOrDefault().Machines.FirstOrDefault()}");


    //foreach (var row in lineReportNew)
    //    Console.WriteLine($"{row.} - {row.ProductionLineName}");

}
