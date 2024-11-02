using MaiaIO.TDD.Aplication.DTO.Devices.Requests;

namespace MaiaIO.TDD.Aplication.Services.Devices.Interfaces
{
    public interface IDeviceAppService
    {
        public Task InsertAsync(DeviceInsertRequest request);
    }
}
