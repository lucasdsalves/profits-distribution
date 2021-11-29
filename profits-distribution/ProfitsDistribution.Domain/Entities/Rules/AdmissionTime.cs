using System;

namespace ProfitsDistribution.Domain.Entities.Rules
{
    public class AdmissionTime : DistributionRules
    {
        private AdmissionTime(Employee employee) : base(employee)
        {

        }

        public static int GetWeightByAdmissionTime(Employee employee)
        {
            var weight = new AdmissionTime(employee);

            return weight.SetWeightBy(employee);
        }

        public override int SetWeightBy(Employee employee)
        {
            var totalDaysAsEmployee = DateTime.Now.Subtract(employee.data_de_admissao).Days;

            var totalYearsAsEmployee = Convert.ToInt32(totalDaysAsEmployee / 365);

            if (totalYearsAsEmployee < 1)
                return 1;
            if (totalYearsAsEmployee < 3)
                return 2;
            if (totalYearsAsEmployee < 8)
                return 3;

            return 5;
        }
    }
}
