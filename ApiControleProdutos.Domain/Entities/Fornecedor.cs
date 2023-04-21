using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiControleProdutos.Domain.Entities
{
    public class Fornecedor
    {
        //atributos
        private Guid _idFornecedor;
        private string? _nome;
        private string? _nomeFantasia;
        private string? _razaoSocial;
        private string? _cnpj;
        private DateTime _dataHoraCriacao;
        private DateTime _dataHoraAlteracao;
        private List<Produto>? _produtos;

        //propriedades
        public Guid IdFornecedor { get => _idFornecedor; set => _idFornecedor = value; }
        public string? Nome { get => _nome; set => _nome = value; }
        public string? NomeFantasia { get => _nomeFantasia; set => _nomeFantasia = value; }
        public string? RazaoSocial { get => _razaoSocial; set => _razaoSocial = value; }
        public string? Cnpj { get => _cnpj; set => _cnpj = value; }
        public DateTime DataHoraCriacao { get => _dataHoraCriacao; set => _dataHoraCriacao = value; }
        public DateTime DataHoraAlteracao { get => _dataHoraAlteracao; set => _dataHoraAlteracao = value; }
        public List<Produto>? Produtos { get => _produtos; set => _produtos = value; }
        
    }
}
