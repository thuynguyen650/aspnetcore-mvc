using Bulky.Models;

namespace Bulky.DataAccess.Repositories.IRepository;

public interface IProductRepository : IRepository<Product>
{
    void Update(Product obj);
}
