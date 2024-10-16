using FluentNHibernate.Mapping;
using Google.Protobuf.WellKnownTypes;
using MaiaIO.TDD.Domain.Devices.Entities;
using MaiaIO.TDD.Domain.Devices.Enums;
using NHibernate.Type;

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
            Map(x => x.TypeDevice).Column("DeviceType").CustomType<TypeDeviceEnum>();
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
