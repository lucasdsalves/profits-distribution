using System.Collections.Generic;

namespace ProfitsDistribution.Domain.Entities
{
    public class ProfitDistribution
    {
        public int total_de_funcionarios { get; set; }
        public string total_distribuido { get; set; }

        public ProfitDistribution (List<Employee> employees)
        {
        }

        public void CalculateProfitsDistribution()
        {

        }
    }
}
