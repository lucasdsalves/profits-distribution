using ProfitsDistribution.Domain.Entities.Rules;
using System;
using Xunit;

namespace ProfitsDistribution.Domain.Tests.ProfitDistributionRulesTests
{
    [Collection(nameof(EmployeeCollection))]
    public class SalaryRuleTests
    {
        private readonly EmployeeTestsFixture _employeeTestsFixture;

        public SalaryRuleTests(EmployeeTestsFixture employeeTestsFixture)
        {
            _employeeTestsFixture = employeeTestsFixture;
        }

        [Theory]
        [InlineData(1500)]
        [InlineData(1800)]
        public void SalaryRule_LessThanTwoThousand_ReturnWeightOne(double employeeSalary)
        {
            // Arrange
            var employee = _employeeTestsFixture.GenerateValidEmployee();
            employee.salario_bruto = employeeSalary;

            // Act
            var weightBySalary = SalaryRule.WeightBySalary(employee);

            // Assert
            Assert.Equal(1, weightBySalary);
        }

        [Theory]
        [InlineData(3500)]
        [InlineData(6999.50)]
        public void SalaryRule_GreaterThanTwoThousandAndLessEqualThanSevenThousand_ReturnWeightTwo(double employeeSalary)
        {
            // Arrange
            var employee = _employeeTestsFixture.GenerateValidEmployee();
            employee.salario_bruto = employeeSalary;

            // Act
            var weightBySalary = SalaryRule.WeightBySalary(employee);

            // Assert
            Assert.Equal(2, weightBySalary);
        }

        [Theory]
        [InlineData(7001)]
        [InlineData(10000)]
        public void SalaryRule_GreaterThanSevenThousand_ReturnWeightFive(double employeeSalary)
        {
            // Arrange
            var employee = _employeeTestsFixture.GenerateValidEmployee();
            employee.salario_bruto = employeeSalary;

            // Act
            var weightBySalary = SalaryRule.WeightBySalary(employee);

            // Assert
            Assert.Equal(5, weightBySalary);
        }

        [Fact]
        public void SalaryRule_IsNull_ReturnArgumentException()
        {
            // Arrange
            var employee = _employeeTestsFixture.GenerateValidEmployee();
            employee.salario_bruto = -5;

            // Act
            var weightBySalary = Record.Exception(() => SalaryRule.WeightBySalary(employee));

            // Assert
            Assert.IsType<ArgumentException>(weightBySalary);
        }
    }
}
