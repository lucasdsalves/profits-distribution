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

        public List<Employee> GenerateValidEmployeeCollection()
        {
            List<Employee> employeeList = new List<Employee>();

            var employeeOne = new Employee();

            employeeOne.matricula = "0007961";
            employeeOne.nome = "Francesca Hewitt";
            employeeOne.area = "Contabilidade";
            employeeOne.cargo = "Auxiliar de Contabilidade";
            employeeOne.salario_bruto = 2101.68;
            employeeOne.data_de_admissao = new DateTime(2018, 05, 21);

            var employeeTwo = new Employee();

            employeeTwo.matricula = "0007961";
            employeeTwo.nome = "Francesca Hewitt";
            employeeTwo.area = "Contabilidade";
            employeeTwo.cargo = "Auxiliar de Contabilidade";
            employeeTwo.salario_bruto = 2101.68;
            employeeTwo.data_de_admissao = new DateTime(2018, 05, 21);

            employeeList.Add(employeeOne);
            employeeList.Add(employeeTwo);
            return employeeList;
        }

        public void Dispose()
        {
        }
    }
}