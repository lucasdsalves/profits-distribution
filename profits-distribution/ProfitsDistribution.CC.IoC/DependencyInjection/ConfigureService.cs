using Microsoft.Extensions.DependencyInjection;
using ProfitsDistribution.Domain.Interfaces.Service;
using ProfitsDistribution.Service;

namespace ProfitsDistribution.CC.IoC.DependencyInjection
{
    public class ConfigureService
    {
        public static void RegisterServicesDependencies(IServiceCollection services)
        {
            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<IProfitsDistributionService, ProfitsDistributionService>();
        }
    }
}
