using AutoMapper;
using ProfitsDistribution.Domain.DTO;
using ProfitsDistribution.Domain.Interfaces.Repository;
using ProfitsDistribution.Domain.Interfaces.Service;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProfitsDistribution.Service
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        private IMapper _mapper;

        public EmployeeService(IEmployeeRepository employeeRepository, IMapper mapper)
        {
            _employeeRepository = employeeRepository;
            _mapper = mapper;
        }

       public async Task<List<EmployeeDto>> GetAllEmployeesAsync()
        {
            return _mapper.Map<List<EmployeeDto>>(await _employeeRepository.GetAllAsync());
        }
    }
}
