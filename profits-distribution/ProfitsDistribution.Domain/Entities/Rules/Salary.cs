using System;

namespace ProfitsDistribution.Domain.Entities.Rules
{
    public class Salary : DistributionRules
    {
        private Salary(Employee employee) : base(employee)
        {

        }

        public static int WeightBySalary(Employee employee)
        {
            var weight = new Salary(employee);

            return weight.SetWeightBy(employee);
        }

        public override int SetWeightBy(Employee employee)
        {
            if (employee.salario_bruto <= 2000)
            {
                return 1;
            }
            else if (employee.salario_bruto > 2000 && employee.salario_bruto <= 7000)
                return 2;
            else
                return 5;

            throw new ArgumentException("Salário não se enquadra.");
        }
    }
}
