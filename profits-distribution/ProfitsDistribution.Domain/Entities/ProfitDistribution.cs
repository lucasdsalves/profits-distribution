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
        }

        public void CalculateProfitsDistribution()
        {
            foreach (var employee in Employees)
            {
                var participation = GetProfit(employee);

                var employeeProfitsPart = new ProfitsEmployeePartDto
                {
                    matricula = employee.matricula,
                    nome = employee.nome,
                    valor_da_participacao = participation.DoubleToStringCurrency()
                };

                Participacoes.Add(employeeProfitsPart);
                total_de_funcionarios++;
                total_distribuido += participation;
            }
        }

        private double GetProfit(Employee employee)
        {
            var weightByAdmisstionTime = AdmissionTime.GetWeightByAdmissionTime(employee);

            var weightByOccupationalArea = OccupationalArea.WeightByOccupationalArea(employee);

            var weightBySalary = Salary.WeightBySalary(employee);

            var totalDistributed = ((weightByAdmisstionTime + weightByOccupationalArea) * employee.salario_bruto * 3) / weightBySalary;

            return Math.Round(totalDistributed, 2);
        }
    }
}
