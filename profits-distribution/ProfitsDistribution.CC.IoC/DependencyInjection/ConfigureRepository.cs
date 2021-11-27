using Firebase.Database;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProfitsDistribution.Domain.Interfaces.Repository;
using ProfitsDistribution.Infra.Data.Repository;
using System.Threading.Tasks;

namespace ProfitsDistribution.CC.IoC.DependencyInjection
{
    public class ConfigureRepository
    {
        public static void ConfigureRepositoryDependencies(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();

            var dbConnectionString = configuration.GetConnectionString("FirebaseDb");
            var dbCredentials = configuration["FirebaseCredential"];

            services.AddScoped(fb => new FirebaseClient(dbConnectionString, new FirebaseOptions { AuthTokenAsyncFactory = () => Task.FromResult(dbCredentials) }));
        }
    }
}
