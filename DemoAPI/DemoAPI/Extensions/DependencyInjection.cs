using DemoAPI.DataModel.Repository;
using DemoAPI.DataModel.Repository.Interface;
using DemoAPI.Mapper;
using DemoAPI.Services;
using DemoAPI.Services.Interface;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DemoAPI.Extensions
{
    public static class DependencyInjection
    {
        public static void ConfigureDomainServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IBookRepository, BookRepository>();
            services.AddScoped<IBookService, BookService>();
            services.AddScoped<ICartRepository,CartRepository>();
            services.AddScoped<ICartService, CartService>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserService, UserService>();
            services.AddAutoMapper(typeof(ProfileMapper));
        }
    }
}
