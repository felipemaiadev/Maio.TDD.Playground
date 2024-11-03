using MaiaIO.TDD.Domain.EntityBase;
using MaiaIO.TDD.Domain.EntityBase.Repositories.Interfaces;
using NHibernate;
using System.Collections;
using System.Linq.Expressions;

namespace MaiaIO.TDD.Infra.BaseEntities.Repositories
{   
        public class NHibernateRepository<T> : INhibernateRepository<T> where T : class
        {

            private readonly ISession session;

            public NHibernateRepository(ISession session)
            {
                this.session = session;
            }
            public void Add(T entity)
            {
                 try
                    {
                        var trs = session.BeginTransaction();
                        session.Save(entity);
                        trs.Commit();
                    }
                 catch (Exception ex) 
                    {
                        Console.WriteLine(ex.Message);
                    }
            }

            public T AddWithReturn(T entity)
            {
                session.Save(entity);
                return entity;
                
            }

            public void Delete(T entity)
            {
                throw new NotImplementedException();
            }

            public T DeleteWithReturn(T entity)
            {
                throw new NotImplementedException();
            }

            public void Update(T entity)
            {
                throw new NotImplementedException();
            }

            public T UpdateWithReturn(T entity)
            {
                throw new NotImplementedException();
            }

            public IQueryable<T> GetAll()
            {
                return session.Query<T>().AsQueryable();    
            }

            public IEnumerator<T> GetEnumerator()
            {
                throw new NotImplementedException();
            }

            public Type ElementType => throw new NotImplementedException();

            public Expression Expression => throw new NotImplementedException();

            public IQueryProvider Provider => throw new NotImplementedException();

            IEnumerator IEnumerable.GetEnumerator()
            {
                throw new NotImplementedException();
            }
        }
}
