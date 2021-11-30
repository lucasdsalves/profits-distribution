using ProfitsDistribution.Domain.DTO;
using ProfitsDistribution.Domain.Entities.Rules;
using ProfitsDistribution.Domain.Tools;
using System;
using System.Collections.Generic;

namespace ProfitsDistribution.Domain.Entities
{
    public class ProfitDistribution
    {
        public List<ProfitsEmployeePartDto> Participacoes { get; set; }
        public int total_de_funcionarios { get; set; }
        public double total_distribuido { get; set; }
        private List<Employee> Employees { get; set; }

        public ProfitDistribution(List<Employee> employees)
        {
            Employees = employees;
            Participacoes = new List<ProfitsEmployeePartDto>();

            IsValid();
        }

        public void DistributeProfitsByEmployee()
        {
            foreach (var employee in Employees)
            {
                var employeeParticipation = CalculateEmployeeBonusParticipation(employee);

                var employeeProfitsPart = new ProfitsEmployeePartDto
                {
                    matricula = employee.matricula,
                    nome = employee.nome,
                    valor_da_participacao = employeeParticipation.DoubleToStringCurrency()
                };

                Participacoes.Add(employeeProfitsPart);
                total_de_funcionarios++;
                total_distribuido += employeeParticipation;
            }
        }

        public double CalculateEmployeeBonusParticipation(Employee employee)
        {
            var weightByAdmissionTime = AdmissionTimeRule.WeightByAdmissionTime(employee);

            var weightByOccupationalArea = OccupationalAreaRule.WeightByOccupationalArea(employee);

            var weightBySalary = SalaryRule.WeightBySalary(employee);

            var totalEmployeeParticipation = ((weightByAdmissionTime + weightByOccupationalArea) * employee.salario_bruto * 3) / weightBySalary;

            return Math.Round(totalEmployeeParticipation, 2);
        }

        #region PRIVATE_AREA
        private void IsValid()
        {
            if (Employees == null)
                throw new ArgumentException("Funcionário encontra-se nulo.");
        }
        #endregion
    }
}
