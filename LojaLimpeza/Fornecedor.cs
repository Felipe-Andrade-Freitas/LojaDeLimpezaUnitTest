using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaLimpeza
{
    public class Fornecedor
    {
        #region Propriedades

        public int IdFornecedor { get; set; }

        public string CNPJ { get; set; }

        public string NomeFantasia { get; set; }

        public string RazaoSocial { get; set; }

        public StatusFornecedor StatusFornecedor { get; set; }

        #endregion

        #region Metodos

        public void VerificarStatus()
        {

        }
        public void RemoverFornecedor()
        {

        }
        public void VerificarFornecedorCadastrado()
        {

        }

        #endregion
    }
}
