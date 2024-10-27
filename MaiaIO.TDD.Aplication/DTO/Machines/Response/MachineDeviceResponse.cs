using MaiaIO.TDD.Domain.Devices.Entities;
using MaiaIO.TDD.Domain.Machines.Entities;

namespace MaiaIO.TDD.API.DTO.Machines.Response
{
    public class MachineDeviceResponse
    {
        public int Id { get; set; }
        public BaseMachine Machine { get; set; }
        public BaseDevice Device { get; set; }

    }
}
