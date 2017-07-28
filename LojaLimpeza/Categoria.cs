using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaLimpeza
{
    public class Categoria
    {
        #region Propriedades

        public int IdCategoria { get; set; }

        public string NomeCategoria { get; set; }

        public IList<Produto> ListaDeProduto = new List<Produto>();

        #endregion

        #region Metodos

        public void RemoverCategoria()
        {

        }
        public void VerificarCategoriaCadastrada()
        {

        }
        #endregion
    }
}
