using ProfitsDistribution.Domain.Entities;
using System;
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
        public void ProfitDistribution_EmployeeIsNotNull_BonusCalculated()
        {
            // Arrange
            var employeeCollection = _employeeTestsFixture.GenerateValidEmployeeCollection();

            var profitsDistribution = new ProfitDistribution(employeeCollection);

            // Act
            profitsDistribution.DistributeProfitsByEmployee();

            // Assert
            Assert.NotNull(profitsDistribution);
        }

        [Fact]
        public void ProfitDistribution_EmployeeIsNull_BonusNotCalculated()
        {
            // Arrange & Act
            var exception = Record.Exception(() => new ProfitDistribution(null));

            // Assert
            Assert.IsType<ArgumentException>(exception);
        }
    }
}
