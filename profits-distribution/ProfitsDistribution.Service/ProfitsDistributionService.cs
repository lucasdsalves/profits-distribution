using AutoMapper;
using ProfitsDistribution.Domain.DTO;
using ProfitsDistribution.Domain.Entities;
using ProfitsDistribution.Domain.Interfaces.Service;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProfitsDistribution.Service
{
    public class ProfitsDistributionService : IProfitsDistributionService
    {
        private readonly IEmployeeService _employeeService;
        private readonly IMapper _mapper;

        public ProfitsDistributionService(IEmployeeService employeeService, IMapper mapper)
        {
            _employeeService = employeeService;
            _mapper = mapper;
        }

        public async Task<ProfitDistributionDto> GetProfitsDistributionAsync()
        {
            var employees = await _employeeService.GetAllEmployeesAsync();

            var profitsDistribution = new ProfitDistribution(_mapper.Map<List<Employee>>(employees));

            profitsDistribution.CalculateProfitsDistribution();

            return (_mapper.Map<ProfitDistributionDto>(profitsDistribution));
        }
    }
}
