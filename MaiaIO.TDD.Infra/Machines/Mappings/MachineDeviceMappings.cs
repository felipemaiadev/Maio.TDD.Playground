using FluentNHibernate.Mapping;
using MaiaIO.TDD.Domain.Machines.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiaIO.TDD.Infra.Machines.Mappings
{
    public class MachineDeviceMappings : ClassMap<MachineDevice>
    {

        public MachineDeviceMappings() 
        {
            Schema("FTW");
            Table("NMachinesDevices");
            Id(x => x.Id).Column("Id");
            Map(x => x.Status).Column("IsActive");
            References(r => r.Device).Column("IDDEVICE").Fetch.Join();
            References(r => r.Machine).Column("IDMACHINE").Fetch.Join();
            
            

        }
    }
}
