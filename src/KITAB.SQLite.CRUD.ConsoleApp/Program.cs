using KITAB.SQLite.CRUD.Application.Notificadores;
using KITAB.SQLite.CRUD.Application.Produtos;
using KITAB.SQLite.CRUD.Infra.Produtos;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace KITAB.SQLite.CRUD.ConsoleApp
{
    class Program
    {
        public static void Main()
        {
            // Create service collection and configure our services
            var services = ConfigureServices();

            // Generate a provider
            var serviceProvider = services.BuildServiceProvider();

            // Kick off our actual code
            serviceProvider.GetService<ConsoleApplication>().Run();
        }

        private static IServiceCollection ConfigureServices()
        {
            IServiceCollection services = new ServiceCollection();

            services.AddAutoMapper(typeof(AutoMapping));

            services.AddScoped<INotificadorService, NotificadorService>();
            services.AddScoped<IProdutoService, ProdutoService>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();

            // IMPORTANT: Register our application entry point
            services.AddScoped<ConsoleApplication>();

            return services;
        }
    }
}
