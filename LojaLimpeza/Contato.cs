using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaLimpeza
{
    public class Contato
    {
        #region Propriedades

        public int IdContato { get; set; }

        public string NomeContato { get; set; }

        public string Email { get; set; }

        public List<Telefone> ListaDeTelefones { get; set; }

        #endregion

        #region Metodos

        public void AdicionaTelefone()
        {

        }

        #endregion
    }
}
