using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProfitsDistribution.Domain.Interfaces.Repository;
using ProfitsDistribution.Infra.Data.Repository;

namespace ProfitsDistribution.CC.IoC.DependencyInjection
{
    public class ConfigureRepository
    {
        public static void ConfigureRepositoryDependencies(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
        }
    }
}
