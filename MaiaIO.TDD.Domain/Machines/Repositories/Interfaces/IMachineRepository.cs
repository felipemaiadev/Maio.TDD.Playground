using MaiaIO.TDD.Domain.Machines.Entities;

namespace MaiaIO.TDD.Domain.Machines.Repositories.Interfaces
{
    public interface IMachineRepository
    {

        public Task<MachineDeviceDTO> GetMachineDevicesById(long id);

    }
}
