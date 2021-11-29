using ProfitsDistribution.Domain.Entities.Rules;
using System;
using Xunit;

namespace ProfitsDistribution.Domain.Tests.ProfitDistributionRulesTests
{
    [Collection(nameof(EmployeeCollection))]
    public class OccupationalAreaRuleTests
    {
        private readonly EmployeeTestsFixture _employeeTestsFixture;

        public OccupationalAreaRuleTests(EmployeeTestsFixture employeeTestsFixture)
        {
            _employeeTestsFixture = employeeTestsFixture;
        }

        [Fact]
        public void OccupationalAreaRule_IsDiretoria_ReturnWeightOne()
        {
            // Arrange
            var employee = _employeeTestsFixture.GenerateValidEmployee();
            employee.area = "Diretoria";

            // Act
            var weightByOccupationalArea = OccupationalAreaRule.WeightByOccupationalArea(employee);

            // Assert
            Assert.Equal(1, weightByOccupationalArea);
        }

        [Fact]
        public void OccupationalAreaRule_IsContabilidadeOrIsFinanceiroOrIsTecnologia_ReturnWeightTwo()
        {
            // Arrange
            var employeeContabilidade = _employeeTestsFixture.GenerateValidEmployee();
            employeeContabilidade.area = "Contabilidade";

            var employeeFinanceiro = _employeeTestsFixture.GenerateValidEmployee();
            employeeFinanceiro.area = "Financeiro";

            var employeeTecnologia = _employeeTestsFixture.GenerateValidEmployee();
            employeeTecnologia.area = "Tecnologia";

            // Act
            var weightByOccupationalContabilidadeArea = OccupationalAreaRule.WeightByOccupationalArea(employeeContabilidade);

            var weightByOccupationalFinanceiroArea = OccupationalAreaRule.WeightByOccupationalArea(employeeFinanceiro);

            var weightByOccupationalTecnologiaArea = OccupationalAreaRule.WeightByOccupationalArea(employeeTecnologia);

            // Assert
            Assert.Equal(2, weightByOccupationalContabilidadeArea);
            Assert.Equal(2, weightByOccupationalFinanceiroArea);
            Assert.Equal(2, weightByOccupationalTecnologiaArea);
        }

        [Fact]
        public void OccupationalAreaRule_IsServicosGerais_ReturnWeightThree()
        {
            // Arrange
            var employee = _employeeTestsFixture.GenerateValidEmployee();
            employee.area = "Serviços Gerais";

            // Act
            var weightByOccupationalArea = OccupationalAreaRule.WeightByOccupationalArea(employee);

            // Assert
            Assert.Equal(3, weightByOccupationalArea);
        }

        [Fact]
        public void OccupationalAreaRule_IsRelacinamentoComOCliente_ReturnWeightThree()
        {
            // Arrange
            var employee = _employeeTestsFixture.GenerateValidEmployee();
            employee.area = "Relacionamento com o Cliente";

            // Act
            var weightByOccupationalArea = OccupationalAreaRule.WeightByOccupationalArea(employee);

            // Assert
            Assert.Equal(5, weightByOccupationalArea);
        }


        [Fact]
        public void OccupationalAreaRule_NonExistantOccupationalArea_ReturnArgumentException()
        {
            // Arrange
            var employee = _employeeTestsFixture.GenerateValidEmployee();
            employee.area = "Marketing";

            // Act
            var weightByOccupationalArea = Record.Exception(() => OccupationalAreaRule.WeightByOccupationalArea(employee));

            // Assert
            Assert.IsType<ArgumentException>(weightByOccupationalArea);
        }
    }
}
