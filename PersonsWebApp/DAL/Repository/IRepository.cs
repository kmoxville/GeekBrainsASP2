namespace PersonsWebApp.DAL.Repository
{
    public interface IRepository<TEntity>
        where TEntity : class
    {
        Task DeleteAsync(int id);

        Task<TEntity?> GetByID(int id);

        IQueryable<TEntity> GetAll();

        Task InsertAsync(TEntity entity);

        Task Update(TEntity entityToUpdate);
    }
}
