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
            .AsQueryable();

        public Task<TEntity?> GetByIDAsync(int id)
        {
            return GetAll().Where(x => x.Id == id)
                .FirstOrDefaultAsync();
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

        public async Task UpdateAsync(TEntity entityToUpdate)
        {
            _context.Update(entityToUpdate);
            await SaveAsync();
        }
    }
}
