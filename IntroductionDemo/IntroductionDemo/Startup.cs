using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace IntroductionDemo
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();
           
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "IntroductionDemo", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // Middlewares 
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "IntroductionDemo v1"));
            }

           /* app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("First Middleware Incoming Request!!\n");
                await next();
                await context.Response.WriteAsync("First Middleware Outgoing Response\n");
            });

            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Second Middleware Incoming Request!!\n");
                await next();
                await context.Response.WriteAsync("Second Middleware Outgoing Response\n");
            });

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("ThirdMiddleware Incoming Request has been handled");
            });*/

            app.UseHttpsRedirection();// next()

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
