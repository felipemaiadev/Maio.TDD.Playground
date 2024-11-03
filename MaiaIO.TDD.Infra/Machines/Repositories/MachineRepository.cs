using MaiaIO.TDD.Domain.Machines.Entities;
using MaiaIO.TDD.Domain.Machines.Repositories.Interfaces;
using MaiaIO.TDD.Infra.BaseEntities.Repositories;
using NHibernate;
using NHibernate.Linq;

namespace MaiaIO.TDD.Infra.Machines.Repositories
{
    public class MachineRepository(ISession session) : NHibernateRepository<BaseMachine>(session), IMachineRepository
    {

        public async Task<MachineDeviceDTO> GetMachineDevicesById(long id)
        {
            
            var result = await session.Query<MachineDevice>()
                                        .Select(m => new MachineDeviceDTO
                                        {
                                            Id = m.Id,
                                            //UID = m.UID,
                                            MachineDescription = m.Machine.Name,
                                            MachineId = m.Machine.Id,
                                            DeviceDescription = m.Device.Description,
                                            DeviceId = m.Device.Id

                                        })
                                        .FirstOrDefaultAsync(x => x.Id == id);

            return result;
        }

        public async Task<bool> InsertAsync(MachineDevice entidade)
        {

            await session.SaveAsync(entidade);
            
            return true;

        }

    }
}
