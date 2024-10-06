namespace MaiaIO.TDD.CLI.Services
{
    public interface IBaseService<T> where T : class
    {

        Task<bool> AddUser(T entity);
        Task<T> RemoveUser(T entity);
        Task<T> GetUserById(Guid id);
    }
}
