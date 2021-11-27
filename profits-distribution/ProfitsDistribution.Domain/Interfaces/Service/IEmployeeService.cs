using ProfitsDistribution.Domain.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProfitsDistribution.Domain.Interfaces.Service
{
    public interface IEmployeeService
    {
        Task<List<EmployeeDto>> GetAllEmployeesAsync();
    }
}
