using MaiaIO.TDD.Domain.Devices.Commands;
using MaiaIO.TDD.Domain.Devices.Entities;


namespace MaiaIO.TDD.Domain.Devices.Servicos.interfaces
{
    public interface IDeviceService
    {
        public Task InsertAsync(BaseDevice baseDevice);
        //Factory UpdateAsync(Factory factory);
        //Factory DeleteAsync(Factory factory);
        public Task<IEnumerable<BaseDevice>> GetListAsync();
        public Task<BaseDevice> GetByIdAsync(long id);
        public BaseDevice Instantiate(DeviceInsertCommand command);
    }
}
