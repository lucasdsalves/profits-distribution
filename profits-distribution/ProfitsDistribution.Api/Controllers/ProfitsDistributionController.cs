﻿using Microsoft.AspNetCore.Mvc;
using ProfitsDistribution.Domain.Interfaces.Service;

namespace ProfitsDistribution.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfitsDistributionController : ControllerBase
    {
        private readonly IProfitsDistributionService _profitsDistributionService;

        public ProfitsDistributionController(IProfitsDistributionService profitsDistributionService)
        {
            _profitsDistributionService = profitsDistributionService;
        }
    }
}
