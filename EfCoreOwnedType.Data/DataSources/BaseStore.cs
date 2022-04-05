namespace EfCoreOwnedType.Data.DataSources
{
    using EfCoreOwnedType.Data;
    using Microsoft.EntityFrameworkCore;
    using System.Linq;

    public class BaseStore<TEntity> where TEntity : class
    {
        private readonly AppDbContext _context;
        public DbSet<TEntity> Items { get; }
        public IQueryable<TEntity> ReadOnlyItems => Items.AsNoTrackingWithIdentityResolution();
        public IQueryable<TEntity> QueryableItems => Items.AsQueryable();

        public BaseStore(AppDbContext context)
        {
            _context = context;
            Items = _context.Set<TEntity>();
        }
    }
}
