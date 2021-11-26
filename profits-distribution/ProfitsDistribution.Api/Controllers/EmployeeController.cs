using Microsoft.AspNetCore.Mvc;
using ProfitsDistribution.Domain.Interfaces.Service;

namespace ProfitsDistribution.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

    }
}
