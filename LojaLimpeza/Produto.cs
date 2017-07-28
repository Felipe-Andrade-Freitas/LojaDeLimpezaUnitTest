using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaLimpeza
{
    public class Produto
    {

        #region Propriedades

        public int IdProduto { get; set; }

        public string CodigoDoProduto { get; set; }

        public string NomeProduto { get; set; }

        public DateTime DataFabricacao { get; set; }

        public DateTime DataValidacao { get; set; }

        public int QuantidadeEmEstoque { get; set; }

        public Categoria Categoria { get; set; }

        public float ValorProduto { get; set; }

        public IList<Produto> ListaDeProdutos = new List<Produto>();

        public IList<ItemPedido> ListaDeItemDoPedido = new List<ItemPedido>();

        public IList<Fornecedor> ListaDeFornecedores = new List<Fornecedor>();

        #endregion

        #region Metodos

        public void VerificarEstoque()
        {

        }
        public void RemoverProduto()
        {

        }
        public void VerificarProdutoCadastrado()
        {

        }

        #endregion
    }
}
