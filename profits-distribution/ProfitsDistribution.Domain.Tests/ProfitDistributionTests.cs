using ProfitsDistribution.Domain.Entities;
using Xunit;

namespace ProfitsDistribution.Domain.Tests
{
    [Collection(nameof(EmployeeCollection))]
    public class ProfitDistributionTests
    {
        private readonly EmployeeTestsFixture _employeeTestsFixture;

        public ProfitDistributionTests(EmployeeTestsFixture employeeTestsFixture)
        {
            _employeeTestsFixture = employeeTestsFixture;
        }

        [Fact]
        public void ProfitDistribution_AreReturnFieldsNull()
        {
            // Arrange
            var employeeCollection = _employeeTestsFixture.GenerateValidEmployeeCollection();

            var profitsDistribution = new ProfitDistribution(employeeCollection);

            // Act
            profitsDistribution.DistributeProfitsByEmployee();

            // Assert
            Assert.NotNull(profitsDistribution.Participacoes);
        }
    }
}
