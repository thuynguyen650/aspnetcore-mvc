using Bulky.Models;

namespace Bulky.DataAccess.Repositories.IRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        void Update(Category obj);
    }
}
