namespace EfCoreOwnedType.Data.DataSources
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using EFCoreOwnedType.Entities.Account;
    using Microsoft.EntityFrameworkCore;

    public class UserStore : BaseStore<User>
    {
        public UserStore(AppDbContext context) : base(context) { }

        public async Task<List<User>> RunSqlCommandAsync(string query, params object[] sqlParameters)
        {
            return await Items.FromSqlRaw(query, sqlParameters)
                              .ToListAsync();
        }
    }
}
