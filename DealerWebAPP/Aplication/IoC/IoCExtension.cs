using DealerWebApp.DealertWeb.Aplication.Data.DDBB;
using DealerWebApp.DealertWeb.Aplication.Data.Repository;
using DealerWebApp.DealertWeb.Aplication.Interfaces.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DealerWebApp.DealertWeb.Aplication.IoC
{
    public static class IoCExtension
    {

        //Conexion a la DB
        public static IServiceCollection AddDealerDbWeb(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DealerWebDbContext>(sqlDB =>
            {
                sqlDB.UseSqlServer("Data Source=(local); Initital Calatalog=DealerDb; Integrated Security=True; MultipleActiveResultSets=True;", sql =>
                {
                    sql.EnableRetryOnFailure();
                    sql.UseNetTopologySuite();

                });

                sqlDB.UseLazyLoadingProxies();

            });

            services.AddSingleton<DealerWebDbContext>();

            return services;

        }

        /// <summary>
        /// AQUI SE VAN A REGISTRAR LOS SERVICIOS PARA UTILIZAR ID
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddDealerServices(this IServiceCollection services)
        {
            services.AddScoped(typeof(IContactosService), typeof(ContactosService));
            services.AddScoped<ICarsService, CarsServices>();

            return services;

        }

        public static void Seed(IServiceProvider serviceProvider)
        {
            using var addScoped = serviceProvider.CreateScope();
            DealerWebDbContext dealerWebDbContext = serviceProvider.GetRequiredService<DealerWebDbContext>();

        }
    }
}
