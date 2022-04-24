namespace PersonsWebApp.Services
{
    public interface IService<TEntity, TDto> 
        where TEntity : class
    {
        Task<TDto> InsertAsync(TDto item);
        Task Update(TDto item);
        Task<bool> Delete(int id);
        Task<TDto> Get(int id);
        IQueryable<TDto> GetAll();
    }
}
