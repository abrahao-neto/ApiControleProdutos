using ApiControleProdutos.Domain.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiControleProdutos.Application.Models
{
    /// <summary>
    /// Modelo para requisiçao de cadastro de fornecedor
    /// </summary>
    public class FornecedorPostModel
    {
        [MinLength(6, ErrorMessage = "Informe no mínimo {1} caracteres.")]
        [MaxLength(100, ErrorMessage = "Informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "O nome do fornecedor é obrigatório.")]
        public string? Nome { get; set; }

        [MinLength(6, ErrorMessage = "Informe no mínimo {1} caracteres.")]
        [MaxLength(100, ErrorMessage = "Informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "O nome fantasia do fornecedor é obrigatório.")]
        public string? NomeFantasia{ get; set; }

        [MinLength(6, ErrorMessage = "Informe no mínimo {1} caracteres.")]
        [MaxLength(100, ErrorMessage = "Informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "A razão social do fornecedor é obrigatório.")]
        public string? RazaoSocial { get; set; }

        [CnpjValidation]
        public string? Cnpj { get; set; }
    }
}
