namespace PersonsWebApp.DAL.Repository
{
    public interface IRepository<TEntity>
        where TEntity : class
    {
        Task DeleteAsync(int id);

        Task<TEntity?> GetByIDAsync(int id);

        IQueryable<TEntity> GetAll();

        Task InsertAsync(TEntity entity);

        Task UpdateAsync(TEntity entityToUpdate);
    }
}
