using System.Collections.Generic;

namespace ProfitsDistribution.Domain.DTO
{
    public class ProfitDistributionDto
    {
        public List<ProfitsEmployeePartDto> participacoes { get; set; }
        public int total_de_funcionarios { get; set; }
        public string total_distribuido { get; set; }
    }
}
