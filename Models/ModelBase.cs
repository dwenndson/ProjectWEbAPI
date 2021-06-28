using System.ComponentModel.DataAnnotations;

namespace projetos.Models
{
    public class ModelBase
    {
        [Required]
        public long Id { get; set; }
        [Required]
        [StringLength(20, ErrorMessage ="Limite maximo de 20 caracteres")]
        [MinLength(3, ErrorMessage ="Minimo de caracteres são 3")]
        public string Nome { get; set; }
        [Required]
        public bool Ativo { get; set; }
    }
}