namespace ProfitsDistribution.Domain.Entities
{
    public abstract class ProfitDistributionRules
    {
        protected Employee Employee;
        protected ProfitDistributionRules(Employee employee)
        {
            Employee = employee;
        }

        public abstract int SetWeightBy(Employee employee);

    }
}
