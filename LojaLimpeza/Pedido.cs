using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaLimpeza
{
    public class Pedido
    {
        #region Propriedades

        public int IdPedido { get; set; }

        public DateTime DataPedido { get; set; }

        public Cliente Cliente { get; set; }

        public IList<ItemPedido> ListaDeItemPedido = new List<ItemPedido>();

        public IList<Pedido> ListaDePedido = new List<Pedido>();

        #endregion

        #region Metodo
        
        public void RemoverStatus()
        {

        }
        public void VerificarStatusCadastrado()
        {

        }

        #endregion
    }
}
