using MaiaIO.TDD.API.DTO.Factories.Response;
using MaiaIO.TDD.Domain.Factories.Entities;

namespace MaiaIO.TDD.API.Services.Factories.NewFolder
{
    public interface IFactoryAppService
    {

        public Task<IEnumerable<FactoryListResponse>> ListarAsync();
        public Task<Factory> GetByIdAsync(long id);
        public Task<Factory> InsertAsync(Factory factory);
        public Task<Factory> UpdateAsync(Factory factory);
        public Task<Factory> RemoveAsync(Factory factory);
        public Task<Factory> RemoveByIdAsync(Guid id);
    }
}
