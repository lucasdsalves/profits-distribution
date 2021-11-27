using ProfitsDistribution.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProfitsDistribution.Domain.Interfaces.Repository
{
    public interface IEmployeeRepository
    {
        Task<List<Employee>> GetAllAsync();
        Task InsertAsync(List<Employee> employees);
        Task DeleteAsync();
    }
}
