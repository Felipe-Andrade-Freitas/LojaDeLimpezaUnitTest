using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LojaLimpeza;

namespace LojaLimpezaUnitTest
{
    [TestCategory("Produto")]
    [TestClass]
    public class CalculoValorTotalItemProduto
    {
        [TestCategory("Produto")]
        [TestMethod]
        public void CalculoValorTotal()
        {
            BaseTest baseTeste = new BaseTest();
            ItemPedido itemPedido = new ItemPedido();
            Produto produto = new Produto();

            baseTeste.PreenchePedidos();
            itemPedido.ValorItemPedido();
            produto.ValorProduto = 4;

            double valorEsperado = 16;
            
            Assert.AreEqual(valorEsperado, itemPedido.ValorTotalItemPedido);
        }
    }
}
