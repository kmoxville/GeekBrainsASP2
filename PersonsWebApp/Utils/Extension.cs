using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection.Extensions;
using PersonsWebApp.DAL;
using PersonsWebApp.DAL.Entities;
using PersonsWebApp.DAL.Repository;
using PersonsWebApp.Services;

namespace PersonsWebApp.Utils
{
    internal static class Extension
    {
        public static IServiceCollection AddDatabaseContext(this IServiceCollection services, IConfiguration configRoot)
        {
            DatabaseOptions dbOptions = new();
            configRoot.GetSection("Database")
                .Bind(dbOptions);

            var connectionString = $"server={dbOptions.Server};user={dbOptions.Username};password={dbOptions.Password};database=ef";
            var serverVersion = new MySqlServerVersion(ServerVersion.AutoDetect(connectionString));

            services.AddDbContext<DatabaseContext>(
            dbContextOptions => dbContextOptions
                .UseMySql(connectionString, serverVersion)
                .LogTo(Console.WriteLine, LogLevel.Information)
                .EnableSensitiveDataLogging()
                .EnableDetailedErrors());

            return services;
        }

        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.TryAddTransient<IRepository<PersonEntity>, Repository<PersonEntity>>();
            services.TryAddTransient<IRepository<UserEntity>, Repository<UserEntity>>();

            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.TryAddTransient<IRepositoryService<PersonEntity, PersonDto>, PersonService>();
            services.TryAddTransient<ILoginService, LoginService>();

            return services;
        }
    }
}
