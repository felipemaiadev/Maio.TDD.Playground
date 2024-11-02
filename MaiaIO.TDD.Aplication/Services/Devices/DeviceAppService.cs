using AutoMapper;
using MaiaIO.TDD.Aplication.DTO.Devices.Requests;
using MaiaIO.TDD.Aplication.Services.Devices.Interfaces;
using MaiaIO.TDD.Domain.Devices.Commands;
using MaiaIO.TDD.Domain.Devices.Servicos.interfaces;

namespace MaiaIO.TDD.Aplication.Services.Devices
{
    public class DeviceAppService( IMapper mapper,
                                   IDeviceService deviceService) : IDeviceAppService
    {
        public async Task InsertAsync(DeviceInsertRequest request)
        {
            var command = mapper.Map<DeviceInsertCommand>(request);
            var baseDevice = deviceService.Instantiate(command);
            await deviceService.InsertAsync(baseDevice);
        }
    }
}
