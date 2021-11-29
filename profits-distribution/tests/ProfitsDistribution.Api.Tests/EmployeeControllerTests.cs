using Microsoft.AspNetCore.Mvc;
using Moq;
using ProfitsDistribution.Api.Controllers;
using ProfitsDistribution.Domain.Interfaces.Service;
using System.Threading.Tasks;
using Xunit;

namespace ProfitsDistribution.Api.Tests
{
    public class EmployeeControllerTests
    {
        [Fact]
        public async Task GetAllEmployees_ShouldReturnSuccessfulCode()
        {
            // Arrange
            var employeeServiceMock = new Mock<IEmployeeService>().Object;
            var employeeControllerMock = new EmployeeController(employeeServiceMock);

            // Act
            var getAllEmployeesReturn = await employeeControllerMock.GetAllEmployees();

            var statusCode = (getAllEmployeesReturn as OkObjectResult).StatusCode;

            // Assert
            Assert.Equal(200, statusCode);
        }
    }
}
