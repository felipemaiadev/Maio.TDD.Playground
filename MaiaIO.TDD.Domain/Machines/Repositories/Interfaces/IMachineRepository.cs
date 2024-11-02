using MaiaIO.TDD.Domain.EntityBase.Repositories.Interfaces;
using MaiaIO.TDD.Domain.Machines.Entities;

namespace MaiaIO.TDD.Domain.Machines.Repositories.Interfaces
{
    public interface IMachineRepository : INhibernateRepository<BaseMachine>
    {

        public Task<MachineDeviceDTO> GetMachineDevicesById(long id);
        public Task<bool> InsertAsync(MachineDevice entidade);

    }
}
