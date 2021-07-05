using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetos.Models
{
    public class Caixa 
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime DataSaida { get; set; }
        public decimal Faturamento { get; set; }
    }
}
