namespace ProfitsDistribution.Domain.Entities.Rules
{
    public class AdmissionTime : DistributionRules
    {
        private AdmissionTime(Employee employee) : base(employee)
        {

        }

        public static AdmissionTime GetWeightByAdmissionTime(Employee employee)
        {
            var weight = new AdmissionTime(employee);

            weight.SetWeightBy(employee);

            return weight;
        }

        public override int SetWeightBy(Employee employee)
        {
            throw new System.NotImplementedException();
        }
    }
}
