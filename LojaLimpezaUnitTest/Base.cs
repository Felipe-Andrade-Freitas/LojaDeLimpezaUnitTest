using LojaLimpeza;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaLimpezaUnitTest
{
    public class Base
    {
        public void Preenche()
        {
            Endereco endereco = new Endereco()
            {
                IdEndereco = 12,
                Rua = "R. Souza Filho",
                Numero = 89,
                Complemento = "Casa 2",
                Bairro = "Pereira",
                Cidade = "Ouro Preto",
                UF = "MG",
                CEP = "36.659.000"
            };

            Telefone telefone = new Telefone()
            {
                IdTelefone = 1,
                NumTelefone = "(31) 3456-3659"
            };

            Contato contato = new Contato()
            {
                IdContato = 1,
                NomeContato = "João José",
                Email = "joao.jose@gmail.com",
            };

            StatusCliente statusCliente = new StatusCliente()
            {
                IdStatus = 1,
                NomeStatus = "Medio"
            };

            Cliente cliente = new Cliente()
            {
                IdCliente = 1,
                NomeCliente = "Maria das Dores Filha",
                CPF = "999.999.999-99",
                Filiacao = "Maria das Dores",
                Contato = contato,
                Endereco = endereco,
                StatusCliente = statusCliente
            };

            Categoria categoria = new Categoria()
            {
                IdCategoria = 1,
                NomeCategoria = "Sabão"                
            };

            Produto produto = new Produto()
            {
                 IdProduto = 1,
                 CodigoDoProduto = "A12345BC6789",
                 NomeProduto = "Sabão em pó",
                 DataFabricacao = new DateTime(2016, 08, 01),
                 DataValidacao = new DateTime(2019, 03, 12),
                 QuantidadeEmEstoque = 196,
                 Categoria = categoria,
                 ValorProduto = 245
            };

            ItemPedido itemPedido = new ItemPedido()
            {
                IdItemPedido = 1,
                QuantidadeProduto = 4,
                Produto = produto    
            };

            Pedido pedido = new Pedido()
            {
                 IdPedido = 1,
                 DataPedido = new DateTime(2017, 02, 01),
                 Cliente = cliente
            };

            StatusFornecedor statusFornecedor = new StatusFornecedor()
            {
                IdStatus = 1,
                NomeStatus = "Bom"
            };

            Fornecedor fornecedor = new Fornecedor()
            {
                IdFornecedor = 1,
                CNPJ = "123",
                NomeFantasia = "LimpeMais",
                RazaoSocial = "LimpeMais",
                StatusFornecedor = statusFornecedor
            };

            contato.ListaDeTelefones.Add(telefone);
            categoria.ListaDeProduto.Add(produto);
            pedido.ListaDeItemPedido.Add(itemPedido);
            pedido.ListaDePedido.Add(pedido);
            cliente.ListaDePedido.Add(pedido);
            produto.ListaDeProdutos.Add(produto);
            produto.ListaDeItemDoPedido.Add(itemPedido);
            produto.ListaDeFornecedores.Add(fornecedor);
        }
    }
}
