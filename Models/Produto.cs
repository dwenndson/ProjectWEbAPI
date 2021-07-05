namespace projetos.Models
{
    public class Produto
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public decimal Quantidade { get; set; }
    }
}