using Microsoft.AspNetCore.Mvc;
using ProfitsDistribution.Domain.Interfaces.Service;
using Swashbuckle.AspNetCore.Annotations;
using System.Threading.Tasks;

namespace ProfitsDistribution.Api.Controllers
{
    [Route("api/employee")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet("get-all")]
        [SwaggerOperation(
            Summary = "Get users collection from Firebase realtime database."
        )]
        public async Task<IActionResult> GetAllEmployees()
        {
            return Ok(await _employeeService.GetAllEmployeesAsync());
        }
    }
}
