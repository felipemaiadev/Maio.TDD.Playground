using MaiaIO.TDD.Domain.Machines.Entities;
using MaiaIO.TDD.Domain.Machines.Repositories.Interfaces;
using NHibernate.Linq;

namespace MaiaIO.TDD.Infra.Machines.Repositories
{
    public class MachineRepository : IMachineRepository
    {
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

            return  result;
        }
    }
}
