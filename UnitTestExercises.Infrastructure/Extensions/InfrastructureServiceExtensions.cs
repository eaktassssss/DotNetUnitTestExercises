using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using UnitTestExercises.Application.Interfaces.Repositories;
using UnitTestExercises.Application.Services;
using UnitTestExercises.Core.Services;
using UnitTestExercises.Infrastructure.Implementations.Repositories;
using UnitTestExercises.Infrastructure.Implementations.Services;

namespace UnitTestExercises.Infrastructure.Extensions
{
    public static class InfrastructureServiceExtensions
    {
        public static IServiceCollection AddMongoDbRepositoriesAndServices(this IServiceCollection services, IConfiguration configuration)
        {
            var mongoDbSettings = new MongoDbSettings();
            configuration.GetSection("MongoDbSettings").Bind(mongoDbSettings);
            services.AddSingleton(mongoDbSettings);

            services.AddSingleton<MongoDbContext>();

            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();

            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IProductService, ProductService>();

            return services;
        }
    }
}