using MaiaIO.TDD.Domain.Devices.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiaIO.TDD.Domain.Machines.Entities
{
    public class MachineDeviceDTO
    {

        public long Id { get; set; }
        //public Guid UID { get; set; }
        public string MachineDescription { get; set; }
        public long MachineId { get; set; }
        public string DeviceDescription { get; set; }
        public long DeviceId { get; set; }
    }
}
