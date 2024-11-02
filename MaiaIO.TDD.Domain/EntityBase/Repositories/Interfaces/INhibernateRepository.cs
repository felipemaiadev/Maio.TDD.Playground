namespace MaiaIO.TDD.Domain.EntityBase.Repositories.Interfaces
{
    public interface INhibernateRepository<T> : IQueryable<T> where T : Entity
    {

        public void Add(T entity);
        public T AddWithReturn(T entity);
        public void Delete(T entity);
        public T DeleteWithReturn(T entity);
        public void Update(T entity);
        public T UpdateWithReturn(T entity);
        public IQueryable<T> GetAll();

    }
}
