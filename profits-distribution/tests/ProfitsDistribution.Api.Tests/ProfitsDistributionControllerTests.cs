using Microsoft.AspNetCore.Mvc;
using Moq;
using ProfitsDistribution.Api.Controllers;
using ProfitsDistribution.Domain.Interfaces.Service;
using System.Threading.Tasks;
using Xunit;

namespace ProfitsDistribution.Api.Tests
{
    public class ProfitsDistributionControllerTests
    {
        [Fact]
        public async Task DistributeProfits_ShouldReturnSuccessfulCode()
        {
            // Arrange
            var profitsDistributionServiceMock = new Mock<IProfitsDistributionService>().Object;
            var profitsDistributionControllerMock = new ProfitsDistributionController(profitsDistributionServiceMock);

            // Act
            var getProfitsDistributionReturn = await profitsDistributionControllerMock.DistributeProfits();

            var statusCode = (getProfitsDistributionReturn as OkObjectResult).StatusCode;

            // Assert
            Assert.Equal(200, statusCode);
        }
    }
}
