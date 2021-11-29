using ProfitsDistribution.Domain.DTO;
using System.Threading.Tasks;

namespace ProfitsDistribution.Domain.Interfaces.Service
{
    public interface IProfitsDistributionService
    {
        Task<ProfitDistributionDto> DistributeProfitsAsync();
    }
}
