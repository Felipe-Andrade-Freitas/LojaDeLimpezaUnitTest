using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaLimpeza
{
    public class Cliente
    {
        # region Propriedades

        public int IdCliente { get; set; }

        public string CodigoDoCliente { get; set; }

        public string NomeCliente { get; set; }

        public string CPF { get; set; }

        public string Filiacao { get; set; }

        public Contato Contato { get; set; }

        public Endereco Endereco { get; set; }

        public StatusCliente StatusCliente { get; set; }

        public IList<Pedido> ListaDePedido = new List<Pedido>();

        #endregion

        #region Metodos

        public void RemoverCliente()
        {

        }
        public void VerificarClienteCadastrado()
        {

        }
        public void VerificarStatus()
        {

        }

        #endregion
    }
}
