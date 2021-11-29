using AutoMapper;
using ProfitsDistribution.Domain.DTO;
using ProfitsDistribution.Domain.Entities;
using ProfitsDistribution.Domain.Tools;

namespace ProfitsDistribution.Domain.AutoMapper
{
    public class DomainToDtoMappingProfile : Profile
    {
        public DomainToDtoMappingProfile()
        {
            EmployeeToEmployeeDto();

            ProfitsDistributionToProfitsDistributionDto();
        }

        private void EmployeeToEmployeeDto()
        {
            CreateMap<Employee, EmployeeDto>()
               .ForMember(dest => dest.matricula, opt => opt.MapFrom(src => src.matricula))
               .ForMember(dest => dest.nome, opt => opt.MapFrom(src => src.nome))
               .ForMember(dest => dest.area, opt => opt.MapFrom(src => src.area))
               .ForMember(dest => dest.cargo, opt => opt.MapFrom(src => src.cargo))
               .ForMember(dest => dest.salario_bruto, opt => opt.MapFrom(src => src.salario_bruto.DoubleToStringCurrency()))
               .ForMember(dest => dest.data_de_admissao, opt => opt.MapFrom(src => src.data_de_admissao.ToString("yyyy-MM-dd")));
        }

        private void ProfitsDistributionToProfitsDistributionDto()
        {
            CreateMap<ProfitDistribution, ProfitDistributionDto>()
               .ForMember(dest => dest.participacoes, opt => opt.MapFrom(src => src.Participacoes))
               .ForMember(dest => dest.total_de_funcionarios, opt => opt.MapFrom(src => src.total_de_funcionarios))
               .ForMember(dest => dest.total_distribuido, opt => opt.MapFrom(src => src.total_distribuido.DoubleToStringCurrency()));
        }
    }
}
