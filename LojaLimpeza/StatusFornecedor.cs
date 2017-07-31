using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaLimpeza
{
    public class StatusFornecedor
    {
        #region Propriedades

        public int IdStatus { get; set; }

        public string NomeStatus { get; set; }

        #endregion

        #region Metodo

        public void RemoverStatus()
        {

        }
        //public bool VerificarStatusCadastrado(string nomeStatus)
        //{
        //    VerificaStatusCadastrado = NomeStatus == nomeStatus;

        //    if(VerificaStatusCadastrado)
        //    {
        //        return true;
        //        throw new System.ArgumentException("Stauts Fornecedor já cadastrado");
        //    }
        //    return false;
        //}

        #endregion
    }
}
