using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiControleProdutos.Application.Models
{
    /// <summary>
    /// Modelo para requisiçao de cadastro de produto
    /// </summary>
    public class ProdutoPostModel
    {
        [MinLength(6, ErrorMessage = "Informe no mínimo {1} caracteres.")]
        [MaxLength(100, ErrorMessage = "Informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "O nome do produto é obrigatório.")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "Preço do produto é obrigatório.")]
        public decimal? Preco { get; set; }

        [Required(ErrorMessage = "Quantidade do produto é obrigatório.")]
        public int Quantidade { get; set; }
    }
}
