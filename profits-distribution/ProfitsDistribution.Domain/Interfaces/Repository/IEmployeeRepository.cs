using ProfitsDistribution.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProfitsDistribution.Domain.Interfaces.Repository
{
    public interface IEmployeeRepository
    {
        Task<List<Employee>> GetAllAsync();
    }
}
