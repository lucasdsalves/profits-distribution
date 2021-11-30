using ProfitsDistribution.Domain.Entities.Rules;
using System;
using Xunit;

namespace ProfitsDistribution.Domain.Tests.ProfitDistributionRulesTests
{
    [Collection(nameof(EmployeeCollection))]
    public class AdmissionTimeRuleTests
    {
        private readonly EmployeeTestsFixture _employeeTestsFixture;

        public AdmissionTimeRuleTests(EmployeeTestsFixture employeeTestsFixture)
        {
            _employeeTestsFixture = employeeTestsFixture;
        }

        [Fact]
        public void AdmissionTimeRule_LessThanOneYear_ReturnWeightOne()
        {
            // Arrange
            var employee = _employeeTestsFixture.GenerateValidEmployee();
            employee.data_de_admissao = new DateTime(2021, 10, 20);

            // Act
            var weightByAdmissionTime = AdmissionTimeRule.WeightByAdmissionTime(employee);

            // Assert
            Assert.Equal(1, weightByAdmissionTime);
        }

        [Fact]
        public void AdmissionTimeRule_GreaterThanOneYearAndLessThanYhreeYears_ReturnWeightTwo()
        {
            // Arrange
            var employee = _employeeTestsFixture.GenerateValidEmployee();
            employee.data_de_admissao = new DateTime(2019, 08, 15);

            // Act
            var weightByAdmissionTime = AdmissionTimeRule.WeightByAdmissionTime(employee);

            // Assert
            Assert.Equal(2, weightByAdmissionTime);
        }

        [Fact]
        public void AdmissionTimeRule_GreaterThanThreeYearsAndLessThanEightYears_ReturnWeightThree()
        {
            // Arrange
            var employee = _employeeTestsFixture.GenerateValidEmployee();
            employee.data_de_admissao = new DateTime(2015, 06, 02);

            // Act
            var weightByAdmissionTime = AdmissionTimeRule.WeightByAdmissionTime(employee);

            // Assert
            Assert.Equal(3, weightByAdmissionTime);
        }


        [Fact]
        public void AdmissionTimeRule_GreaterThanEightYears_ReturnWeightFive()
        {
            // Arrange
            var employee = _employeeTestsFixture.GenerateValidEmployee();
            employee.data_de_admissao = new DateTime(2010, 11, 08);

            // Act
            var weightByAdmissionTime = AdmissionTimeRule.WeightByAdmissionTime(employee);

            // Assert
            Assert.Equal(5, weightByAdmissionTime);
        }
    }
}