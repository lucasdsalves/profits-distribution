using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using ProfitsDistribution.Domain.AutoMapper;

namespace ProfitsDistribution.CC.IoC.AutoMapper
{
    public static class AutoMapperSetup
    {
        public static void ConfigureMappers(IServiceCollection service)
        {
            var mappingConfig = new MapperConfiguration(m =>
            {
                m.AddProfile(new DtoToDomainMappingProfile());
                m.AddProfile(new DomainToDtoMappingProfile());
            });

            IMapper mapper = mappingConfig.CreateMapper();

            service.AddSingleton(mapper);
        }
    }
}
