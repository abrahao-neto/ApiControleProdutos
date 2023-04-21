using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiControleProdutos.Domain.Entities
{
    public class Produto
    {
        //atributos
        private Guid _idProduto;
        private string? _nome;
        private decimal? _preco;
        private int _quantidade;
        private DateTime _dataHoraCriacao;
        private DateTime _dataHoraAlteracao;
        private Guid _idFornecedor;
        private Fornecedor? _fornecedor;

        //propriedades
        public Guid IdProduto { get => _idProduto; set => _idProduto = value; }
        public string? Nome { get => _nome; set => _nome = value; }
        public decimal? Preco { get => _preco; set => _preco = value; }
        public int Quantidade { get => _quantidade; set => _quantidade = value; }
        public DateTime DataHoraCriacao { get => _dataHoraCriacao; set => _dataHoraCriacao = value; }
        public DateTime DataHoraAlteracao { get => _dataHoraAlteracao; set => _dataHoraAlteracao = value; }
        public Fornecedor? Fornecedor { get => _fornecedor; set => _fornecedor = value; }
        public Guid IdFornecedor { get => _idFornecedor; set => _idFornecedor = value; }

    }

}
