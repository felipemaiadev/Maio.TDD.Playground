using MaiaIO.TDD.Domain.Devices.Commands;
using MaiaIO.TDD.Domain.Devices.Entities;
using MaiaIO.TDD.Domain.Devices.Repositories;
using MaiaIO.TDD.Domain.Devices.Servicos.interfaces;

namespace MaiaIO.TDD.Domain.Devices.Servicos
{
    public class DeviceService(IDeviceRepository deviceRepository) : IDeviceService
    {
        public async Task InsertAsync(BaseDevice baseDevice)
        {
            await deviceRepository.InsertAsync(baseDevice);
        }

        public async Task<IEnumerable<BaseDevice>> GetListAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<BaseDevice> GetByIdAsync(long id)
        {
            return await deviceRepository.GetByIdAsync(id);
        }


        public BaseDevice Instantiate(DeviceInsertCommand command)
        {
            var device = new BaseDevice(command.Description, command.Vendor, command.TypeDevice, command.VendorCodeUID, command.VendorSerialNumber);

            return device;
        }

    }
}
