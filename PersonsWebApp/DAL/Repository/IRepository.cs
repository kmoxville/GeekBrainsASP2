namespace PersonsWebApp.DAL.Repository
{
    public interface IRepository<TEntity>
        where TEntity : class
    {
        Task DeleteAsync(int id);

        Task<TEntity?> GetByID(int id);

        IEnumerable<TEntity> GetAll();

        Task InsertAsync(TEntity entity);

        void Update(TEntity entityToUpdate);

        Task SaveAsync();
    }
}
