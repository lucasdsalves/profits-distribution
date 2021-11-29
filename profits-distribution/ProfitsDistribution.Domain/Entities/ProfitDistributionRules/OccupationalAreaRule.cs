using System;

namespace ProfitsDistribution.Domain.Entities.Rules
{
    public class OccupationalAreaRule : ProfitDistributionRules
    {
        private OccupationalAreaRule(Employee employee) : base(employee)
        {

        }

        public static int WeightByOccupationalArea(Employee employee)
        {
            var weight = new OccupationalAreaRule(employee);

            return weight.SetWeightBy(employee);
        }

        public override int SetWeightBy(Employee employee)
        {
            switch (employee.area)
            {
                case "Diretoria":
                    return 1;

                case "Contabilidade":
                case "Financeiro":
                case "Tecnologia":
                    return 2;

                case "Serviços Gerais":
                    return 3;

                case "Relacionamento com o Cliente":
                    return 5;
            }

            throw new ArgumentException("Departamento inexistente.");
        }
    }
}
