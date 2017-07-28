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

        public Produto Produto { get; set; }

        #endregion

        #region Metodos

        public void SelecaoQuantidadeProduto()
        {

        }
        public void VerificarEstoque()
        {

        }

        #endregion
    }
}
