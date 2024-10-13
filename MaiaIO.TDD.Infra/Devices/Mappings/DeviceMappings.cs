using FluentNHibernate.Mapping;
using MaiaIO.TDD.Domain.Devices.Entities;
using MaiaIO.TDD.Domain.Devices.Enums;

namespace MaiaIO.TDD.Infra.Devices.Mappings
{
    public class BaseDeviceMappings : ClassMap<BaseDevice>
    {

        public BaseDeviceMappings()
        {
            Schema("FTW");
            Table("Device");
            Id(x => x.Id).Column("Id");
            Map(x => x.UID).Column("UID");
            Map(x => x.Description).Column("Description");
            Map(x => x.Vendor).Column("VendorID").CustomType<TypeVendorEnum>();
            Map(x => x.TypeDevice).Column("DeviceType").CustomType<TypeDeviceEnum>(); //CRIAR NA TABELA
            Map(x => x.VendorCodeUID).Column("VendorUID");
            Map(x => x.VendorSerialNumber).Column("VendorSerialNumber");


            HasManyToMany(r => r.Machines)
                .Schema("FTW")
                .Table("NMachinesDevices")
                .ParentKeyColumn("IDMACHINE")
                .ChildKeyColumn("IDDEVICE");
        }
    }
}
