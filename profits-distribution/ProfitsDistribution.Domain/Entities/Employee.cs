using System;

namespace ProfitsDistribution.Domain.Entities
{
    public class Employee
    {
		public string matricula { get; set; }
		public string nome { get; set; }
		public string area { get; set; }
		public string cargo { get; set; }
		public double salario_bruto { get; set; }
		public DateTime data_de_admissao { get; set; }
	}
}
