using MaiaIO.TDD.Domain.Machines.Entities;
using MaiaIO.TDD.Domain.Machines.Repositories.Interfaces;
using MaiaIO.TDD.Infra.BaseEntities.Repositories;
using NHibernate;
using NHibernate.Linq;

namespace MaiaIO.TDD.Infra.Machines.Repositories
{
    public class MachineRepository : NHibernateRepository<BaseMachine>, IMachineRepository
    {
        public MachineRepository(ISession session) : base(session) { }

        public async Task<MachineDeviceDTO> GetMachineDevicesById(long id)
        {
            DbContext.Initialize();
            var session = DbContext.OpenSession();

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

            DbContext.Initialize();
            var session = DbContext.OpenSession();

            await session.SaveAsync(entidade);
            
            return true;

        }

    }
}
