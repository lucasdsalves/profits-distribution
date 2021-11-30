using Bogus;
using Bogus.DataSets;
using ProfitsDistribution.Domain.Entities;
using System;
using System.Collections.Generic;
using Xunit;

namespace ProfitsDistribution.Domain.Tests
{
    [CollectionDefinition(nameof(EmployeeCollection))]
    public class EmployeeCollection : ICollectionFixture<EmployeeTestsFixture>
    { }

    public class EmployeeTestsFixture : IDisposable
    {
        private string[] occupationalAreas = new[] { "Diretoria", "Contabilidade", "Financeiro", "Tecnologia", "Serviços Gerais", "Relacionamento com o Cliente" };
        private string[] roles = new[] { "Diretor Financeiro", "Auxiliar de Contabilidade", "Auxiliar Administrativo", "Atendente", "Analista" };

        public Employee GenerateValidEmployee()
        {
            var fakeEmployeeGender = new Faker().PickRandom<Name.Gender>();

            var faker = new Faker();

            var employee = new Employee()
            {
                matricula = new Randomizer().Replace("#######"),
                nome = faker.Name.FirstName(fakeEmployeeGender) + " " + faker.Name.LastName(fakeEmployeeGender),
                area = faker.PickRandom(occupationalAreas),
                cargo = faker.PickRandom(roles),
                salario_bruto = Math.Round(faker.Random.Double(0, 20000), 2),
                data_de_admissao = faker.Date.Between(new DateTime(2001, 01, 01), DateTime.Now)
            };

            return employee;
        }

        public List<Employee> GenerateValidEmployeeCollection()
        {
            List<Employee> employeeList = new List<Employee>();

            var fakeEmployeeGender = new Faker().PickRandom<Name.Gender>();

            var faker = new Faker();

            var employeeOne = new Employee()
            {
                matricula = new Randomizer().Replace("#######"),
                nome = faker.Name.FirstName(fakeEmployeeGender) + " " + faker.Name.LastName(fakeEmployeeGender),
                area = faker.PickRandom(occupationalAreas),
                cargo = faker.PickRandom(roles),
                salario_bruto = Math.Round(faker.Random.Double(0, 20000), 2),
                data_de_admissao = faker.Date.Between(new DateTime(2001, 01, 01), DateTime.Now)
            };

            var employeeTwo = new Employee()
            {
                matricula = new Randomizer().Replace("#######"),
                nome = faker.Name.FirstName(fakeEmployeeGender) + " " + faker.Name.LastName(fakeEmployeeGender),
                area = faker.PickRandom(occupationalAreas),
                cargo = faker.PickRandom(roles),
                salario_bruto = Math.Round(faker.Random.Double(0, 20000), 2),
                data_de_admissao = faker.Date.Between(new DateTime(2001, 01, 01), DateTime.Now)
            };

            employeeList.Add(employeeOne);
            employeeList.Add(employeeTwo);

            return employeeList;
        }

        public void Dispose()
        {
        }
            
    }
}