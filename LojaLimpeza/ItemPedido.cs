using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaLimpeza
{
    public class ItemPedido
    {
        #region Propriedades

        public int IdItemPedido { get; set; }

        public int QuantidadeProduto { get; set; }

        public float ValorTotalItemPedido { get; set; }

        public Produto Produto { get; set; }

        #endregion

        #region Metodos
        Produto produto = new Produto();

        public void ValorItemPedido()
        {            
            ValorTotalItemPedido = produto.ValorProduto * QuantidadeProduto;
        }
        public void SelecaoQuantidadeProduto()
        {

        }
        public void VerificarEstoque()
        {

        }

        #endregion
    }
}
