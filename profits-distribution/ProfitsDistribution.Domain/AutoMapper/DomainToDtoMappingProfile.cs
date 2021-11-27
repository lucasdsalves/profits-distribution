using AutoMapper;
using ProfitsDistribution.Domain.DTO;
using ProfitsDistribution.Domain.Entities;

namespace ProfitsDistribution.Domain.AutoMapper
{
    public class DomainToDtoMappingProfile : Profile
    {
        public DomainToDtoMappingProfile()
        {
            EmployeeToEmployeeDto();
        }

        private void EmployeeToEmployeeDto()
        {
            CreateMap<Employee, EmployeeDto>()
               .ForMember(dest => dest.matricula, opt => opt.MapFrom(src => src.matricula))
               .ForMember(dest => dest.nome, opt => opt.MapFrom(src => src.nome))
               .ForMember(dest => dest.area, opt => opt.MapFrom(src => src.area))
               .ForMember(dest => dest.cargo, opt => opt.MapFrom(src => src.cargo))
               .ForMember(dest => dest.salario_bruto, opt => opt.MapFrom(src => src.salario_bruto))
               .ForMember(dest => dest.data_de_admissao, opt => opt.MapFrom(src => src.data_de_admissao));
        }
    }
}
