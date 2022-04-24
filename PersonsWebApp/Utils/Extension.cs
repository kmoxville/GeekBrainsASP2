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

            return services;
        }

        public static IServiceCollection AddDtoServices(this IServiceCollection services)
        {
            services.TryAddTransient<IService<PersonEntity, PersonDto>, PersonService>();

            return services;
        }
    }
}
