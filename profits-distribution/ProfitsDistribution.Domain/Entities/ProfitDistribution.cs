using ProfitsDistribution.Domain.Entities.Rules;
using System.Collections.Generic;

namespace ProfitsDistribution.Domain.Entities
{
    public class ProfitDistribution
    {
        public int total_de_funcionarios { get; set; }
        public string total_distribuido { get; set; }
        private List<Employee> Employees { get; set; }

        public ProfitDistribution(List<Employee> employees)
        {
            Employees = employees;
        }

        public void CalculateProfitsDistribution()
        {
            foreach (var employee in Employees)
            {
                var participation = GetProfit(employee);
            }

        }

        private double GetProfit(Employee employee)
        {
            //var weightByAdmisstionTime = AdmissionTime.GetWeightByAdmissionTime(employee);

            var weightByOccupationalArea = OccupationalArea.WeightByOccupationalArea(employee);

            var b = 10;

            var c = b * weightByOccupationalArea;

            //var weightBySalary = Salary.WeightBySalary(employee);

            //var profitDistribution = (employee.salario_bruto * weightByAdmisstionTime);
            return 2;

        }
    }
}
