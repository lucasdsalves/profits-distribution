namespace ProfitsDistribution.Domain.Entities
{
    public abstract class DistributionRules
    {
        protected Employee Employee;
        protected DistributionRules(Employee employee)
        {
            Employee = employee;
        }

        public abstract int SetWeightBy(Employee employee);
    }
}
