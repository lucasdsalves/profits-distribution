using Microsoft.AspNetCore.Mvc;
using ProfitsDistribution.Domain.Interfaces.Service;
using Swashbuckle.AspNetCore.Annotations;
using System.Threading.Tasks;

namespace ProfitsDistribution.Api.Controllers
{
    [Route("api/profits-distribution")]
    [ApiController]
    public class ProfitsDistributionController : ControllerBase
    {
        private readonly IProfitsDistributionService _profitsDistributionService;

        public ProfitsDistributionController(IProfitsDistributionService profitsDistributionService)
        {
            _profitsDistributionService = profitsDistributionService;
        }

        [HttpGet("distribute-profits")]
        [SwaggerOperation(
            Summary = "Distribute profits by employee and get its participation value."
        )]
        public async Task<IActionResult> DistributeProfits()
        {
            return Ok(await _profitsDistributionService.DistributeProfitsAsync());
        }
    }
}
