using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using ProfitsDistribution.CC.IoC.AutoMapper;
using ProfitsDistribution.CC.IoC.DependencyInjection;

namespace ProfitsDistribution.Api
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
            // Dependency Injection
            ConfigureService.RegisterServicesDependencies(services);
            ConfigureRepository.ConfigureRepositoryDependencies(services, Configuration);

            // AutoMapper
            AutoMapperSetup.ConfigureMappers(services);

            services.AddControllers();

            // Swagger
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Profits Distribution API",
                    Version = "v1",
                    Contact = new OpenApiContact
                    {
                        Name = "Lucas dos Santos Alves",
                        Url = new System.Uri("https://github.com/lucasdsalves")
                    },
                    Description = "Distribute profits by employee based on admission time weight, occupational area weight and salary weight."
                });

                c.EnableAnnotations();
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ProfitsDistribution.Api v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
