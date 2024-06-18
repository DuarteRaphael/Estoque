using Estoque.Domain.Core.Intarfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.Domain.Entities
{
    public class Produto : IEntity
    {
        public Guid Id { get; set; }
        public string? Nome { get; set; }

        #region Atributos
        private string? _fabricante;
        private int _quantidade;
        private decimal _preco;
        private DateTime _datafabricacao;
        private DateTime _datavalidade;
        #endregion

        #region Propiedades
        public string? Fabricante { get => _fabricante; set => _fabricante = value; }
        public int Quantidade { get => _quantidade; set => _quantidade = value; }
        public decimal Preco { get => _preco; set => _preco = value; }
        public DateTime DataFabricacao { get => _datafabricacao; set => _datafabricacao = value; }
        public DateTime DataValidade { get => _datavalidade; set => _datavalidade = value; }
        #endregion
    }
}
