using Microsoft.EntityFrameworkCore;
using PersonsWebApp.DAL.Entities;

namespace PersonsWebApp.DAL.Repository
{
    public class Repository<TEntity> : IRepository<TEntity>
        where TEntity : BaseEntity
    {
        private readonly DatabaseContext _context;
        private readonly DbSet<TEntity> _dbSet;

        public Repository(DatabaseContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        public async Task DeleteAsync(int id)
        {
            TEntity? entityToDelete = await _dbSet.FindAsync(id);
            entityToDelete?.Delete();
            await SaveAsync();
        }

        public IQueryable<TEntity> GetAll() => _dbSet
            .Where(entity => !entity.IsDeleted)
            .AsQueryable()
            .AsNoTracking();

        public async Task<TEntity?> GetByID(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task InsertAsync(TEntity entity)
        {
            await _dbSet.AddAsync(entity);
            await SaveAsync();
        }

        private async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        public async Task Update(TEntity entityToUpdate)
        {
            _dbSet.Attach(entityToUpdate);
            _context.Entry(entityToUpdate).State = EntityState.Modified;
            await SaveAsync();
        }
    }
}
