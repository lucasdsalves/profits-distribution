namespace ProfitsDistribution.Domain.Entities.Rules
{
    public class Salary : DistributionRules
    {
        private Salary(Employee employee) : base(employee)
        {

        }

        public static Salary WeightBySalary(Employee employee)
        {
            var weight = new Salary(employee);

            weight.SetWeightBy(employee);

            return weight;
        }

        public override int SetWeightBy(Employee employee)
        {
            //if (employee.salario_bruto <= 2000)
            //{
            //    return 1;
            //}
            //else if (employee.salario_bruto > 2000 && employee.salario_bruto <= 7000)
            //    return 2;
            //else
            //    return 5;

            throw new System.NotImplementedException();
        }
    }
}
