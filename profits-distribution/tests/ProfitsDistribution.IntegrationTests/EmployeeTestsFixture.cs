using ProfitsDistribution.Domain.Entities;
using System;
using Xunit;

namespace ProfitsDistribution.IntegrationTests
{
    [CollectionDefinition(nameof(EmployeeCollection))]
    public class EmployeeCollection : ICollectionFixture<EmployeeTestsFixture>
    { }

    public class EmployeeTestsFixture : IDisposable
    {
        public Employee GenerateValidEmployee()
        {
            var employee = new Employee();

            employee.matricula = "0007961";
            employee.nome = "Francesca Hewitt";
            employee.area = "Contabilidade";
            employee.cargo = "Auxiliar de Contabilidade";
            employee.salario_bruto = 2101.68;
            employee.data_de_admissao = new DateTime(2018, 05, 21);

            return employee;
        }

        public void Dispose()
        {
        }
    }
}