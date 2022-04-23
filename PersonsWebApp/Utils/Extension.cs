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
        public static IServiceCollection AddDatabaseContext(this IServiceCollection services)
        {
            services.AddDbContext<DatabaseContext>(opt => opt.UseInMemoryDatabase("PersonsWebApp"));

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
