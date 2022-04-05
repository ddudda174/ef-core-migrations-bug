namespace EfCoreOwnedType.WebApi
{
    using EfCoreOwnedType.Data;
    using EfCoreOwnedType.WebApi.Extensions;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;

    public class Startup
    {
        private readonly IConfiguration _config;
        private readonly IWebHostEnvironment _environment;

        public Startup(IConfiguration config, IWebHostEnvironment environment)
        {
            _config = config;
            _environment = environment;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext(_config.GetConnectionString("MariaDb"))
                    .AddDataStores();
        }

        public void Configure(IApplicationBuilder app, AppDbContext dbContext)
        {
            if (_environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();

            app.UseCors(policy => policy.AllowAnyHeader()
                                        .AllowAnyMethod()
                                        .AllowCredentials());

            app.UseWebSockets();
            app.UseEndpoints(endpoints =>
                             {
                                 endpoints.MapControllers();
                             });

            dbContext.Database.Migrate();
        }
    }
}
