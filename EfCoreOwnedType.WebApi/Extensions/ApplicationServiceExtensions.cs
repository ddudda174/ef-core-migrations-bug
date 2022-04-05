namespace EfCoreOwnedType.WebApi.Extensions
{
    using System;
    using EfCoreOwnedType.Data;
    using EfCoreOwnedType.Data.DataSources;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;

    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddDbContext(this IServiceCollection services, string connectionString)
        {
            var serverVersion = new MariaDbServerVersion(new Version(10, 7)); // changed from Version 10.6, but didn't make a difference

            services.AddDbContextPool<AppDbContext>(options =>
                                                    {
                                                        options.UseMySql(connectionString, serverVersion, mysqlOptions =>
                                                                                                          {
                                                                                                              mysqlOptions.EnableRetryOnFailure(maxRetryCount: 10,
                                                                                                                                                maxRetryDelay: TimeSpan.FromSeconds(30),
                                                                                                                                                errorNumbersToAdd: null);
                                                                                                          });
                                                    });

            return services;
        }

        public static IServiceCollection AddDataStores(this IServiceCollection services)
        {
            services.AddScoped(typeof(BaseStore<>));
            services.AddScoped<UserStore>();

            return services;
        }
    }
}
