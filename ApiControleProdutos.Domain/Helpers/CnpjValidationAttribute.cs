using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiControleProdutos.Domain.Helpers
{
    public class CnpjValidationAttribute : RegularExpressionAttribute
    {
        public CnpjValidationAttribute() : base(@"^\d{2}\.\d{3}\.\d{3}\/\d{4}\-\d{2}$")
        {
            ErrorMessage = "CNPJ inválido";
        }
    }
}
