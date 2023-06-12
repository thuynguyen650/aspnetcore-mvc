using System.Linq.Expressions;

namespace Bulky.DataAccess.Repositories.IRepository
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();

        T Get(Expression<Func<T, bool>> filter);

        void Add(T entity);

        void Delete(T entity);

        void Remove(T entity);

        void RemoveRange(IEnumerable<T> entities);
    }   
}
