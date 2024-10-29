using MaiaIO.TDD.Domain.Devices.Entities;
using MaiaIO.TDD.Domain.Machines.Entities;

namespace MaiaIO.TDD.API.DTO.Machines.Response
{
    public class MachineDeviceResponse
    {
        public long Id { get; set; }
        //public Guid UID { get; set; }
        public string MachineDescription { get; set; }
        public long MachineId { get; set; }
        public string DeviceDescription { get; set; }
        public long DeviceId { get; set; }

    }
}
