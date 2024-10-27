using MaiaIO.TDD.API.DTO.Factories.Response;
using MaiaIO.TDD.Aplication.DTO.Factories.Requests;

namespace MaiaIO.TDD.API.Services.Factories.Interfaces
{
    public interface IFactoryAppService
    {

        public Task<IEnumerable<FactoryListResponse>> ListarAsync();
        public Task<FactoryResponse> GetByIdAsync(long id);
        public Task<FactoryResponse> InsertAsync(FactoryInsertRequest factory);
        //public Task<Factory> UpdateAsync(Factory factory);
        //public Task<Factory> RemoveAsync(Factory factory);
        //public Task<Factory> RemoveByIdAsync(Guid id);
    }
}
