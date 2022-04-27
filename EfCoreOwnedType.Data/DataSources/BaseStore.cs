namespace EfCoreOwnedType.Data.DataSources
{
    using System.Linq;
    using Microsoft.EntityFrameworkCore;

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
