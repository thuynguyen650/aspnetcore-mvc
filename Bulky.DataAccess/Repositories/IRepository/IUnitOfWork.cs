namespace Bulky.DataAccess.Repositories.IRepository
{
    public interface IUnitOfWork
    {
        ICategoryRepository categoryRepository { get; }

        void Save();
    }
}
