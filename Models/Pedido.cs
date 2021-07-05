using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetos.Models
{
    public class Pedido 
    {
        public long Id { get; set; }
        public List<Produto> Produtos { get; set; }
        public DateTime DataVenda { get; set; }
        public decimal Valor { get; set; }
        public long Idcaixa { get; set; }
        public virtual Caixa IdCaixa { get; set; }
    }
}
