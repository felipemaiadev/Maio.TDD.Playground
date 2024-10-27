using FluentNHibernate.Mapping;
using MaiaIO.TDD.Domain.Machines.Entities;
using System.Reflection.PortableExecutable;

namespace MaiaIO.TDD.Infra.Machines.Mappings
{
    public class MachineMappings : ClassMap<BaseMachine>
    {

        public MachineMappings()
        {
            Schema("FTW");
            Table("Machine");
            Id(x => x.Id).Column("Id");
            Map(x => x.UID).Column("UID");
            Map(x => x.Name).Column("Name");
            Map(x => x.InventoryCode).Column("InventoryCode");
            Map(x => x.IdProductionLine).Column("ProductionLine_Id").Not.Update();
            References(r => r.ProductionLine).Not.LazyLoad();

            HasManyToMany(r => r.DeviceList)
                .Schema("FTW")
                .Table("NMachinesDevices")
                .ParentKeyColumn("IDMACHINE")
                .ChildKeyColumn("IDDEVICE")
                .Fetch
                .Join();



        }
    }
}
