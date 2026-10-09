using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tp03.Models
{
    public class Produto
    {
        [Key]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome do produto é de preenchimento obrigatório.")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "O nome deve conter entre 2 e 100 caracteres.")]
        [Display(Name = "Nome do Produto")]
        public string Nome { get; set; } = string.Empty;

        [Required(ErrorMessage = "A descrição do produto é de preenchimento obrigatório.")]
        [StringLength(500, MinimumLength = 5, ErrorMessage = "A descrição deve conter no mínimo 5 e no máximo 500 caracteres.")]
        [Display(Name = "Descrição Detalhada")]
        [DataType(DataType.MultilineText)]
        public string Descricao { get; set; } = string.Empty;

        [Required(ErrorMessage = "O preço unitário é obrigatório.")]
        [Range(0.01, 999999.99, ErrorMessage = "O preço deve ser superior a zero (mínimo de R$ 0,01).")]
        [Column(TypeName = "decimal(18,2)")]
        [DataType(DataType.Currency)]
        [Display(Name = "Preço Unitário (R$)")]
        public decimal Preco { get; set; }

        [Required(ErrorMessage = "A quantidade em estoque é obrigatória.")]
        [Range(0, 100000, ErrorMessage = "A quantidade em estoque não pode ser negativa.")]
        [Display(Name = "Quantidade em Estoque")]
        public int QuantidadeEmEstoque { get; set; }
    }
}