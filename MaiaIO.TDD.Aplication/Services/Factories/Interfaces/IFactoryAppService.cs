using MaiaIO.TDD.API.DTO.Factories.Response;
using MaiaIO.TDD.Aplication.DTO.Factories.Requests;
using MaiaIO.TDD.Aplication.DTO.Factories.Response;

namespace MaiaIO.TDD.API.Services.Factories.Interfaces
{
    public interface IFactoryAppService
    {

        public Task<IEnumerable<FactoryListResponse>> ListarAsync();
        public Task<FactoryResponse> GetByIdAsync(long id);
        public Task<FactoryResponse> InsertAsync(FactoryInsertRequest factory);
        public Task<FactoryResponse> EditAsync(FactoryEditRequest factory);
        public Task<FactoryResponse> RemoveByIdAsync(long id);
    }
}
