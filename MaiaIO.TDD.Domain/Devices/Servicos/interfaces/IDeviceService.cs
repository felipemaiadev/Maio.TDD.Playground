using MaiaIO.TDD.Domain.Factories.Entities;


namespace MaiaIO.TDD.Domain.Devices.Servicos.interfaces
{
    public interface IDeviceService
    {
        Factory InsertAsync(Factory factory);
        Factory UpdateAsync(Factory factory);
        Factory DeleteAsync(Factory factory);
        Task<IEnumerable<Factory>> GetListAsync();
        Task<Factory> GetByIdAsync(long id);
    }
}
