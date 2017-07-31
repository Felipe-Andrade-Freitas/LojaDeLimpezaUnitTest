using LojaLimpeza;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaLimpezaUnitTest
{
    public class BaseTest
    {
        public ItemPedido PreenchePedidos()
        {
            //Cadastro do Cliente

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

            //Cadastro das Categorias
            Categoria banheiros = new Categoria()
            {
                IdCategoria = 1,
                NomeCategoria = "Banheiro"
            };

            Categoria lavanderia = new Categoria()
            {
                IdCategoria = 1,
                NomeCategoria = "Lavanderia"
            };

            Categoria loucas = new Categoria()
            {
                IdCategoria = 1,
                NomeCategoria = "Louças"
            };

            //Cadastro dos Produtos
            Produto vejaBanheiro = new Produto()
            {
                IdProduto = 1,
                CodigoDoProduto = "BAN001",
                NomeProduto = "Veja Limpeza Total",
                DataFabricacao = new DateTime(2016, 08, 01),
                DataValidacao = new DateTime(2019, 03, 12),
                QuantidadeEmEstoque = 196,
                Categoria = banheiros,
                ValorProduto = 4
            };

            Produto omo = new Produto()
            {
                IdProduto = 1,
                CodigoDoProduto = "LAV001",
                NomeProduto = "Sabão em pó - OMO",
                DataFabricacao = new DateTime(2016, 08, 01),
                DataValidacao = new DateTime(2019, 03, 12),
                QuantidadeEmEstoque = 196,
                Categoria = lavanderia,
                ValorProduto = 245
            };

            Produto vejaLoucas = new Produto()
            {
                IdProduto = 1,
                CodigoDoProduto = "LOU001",
                NomeProduto = "Veja Multiuso",
                DataFabricacao = new DateTime(2016, 08, 01),
                DataValidacao = new DateTime(2019, 03, 12),
                QuantidadeEmEstoque = 196,
                Categoria = loucas,
                ValorProduto = 245
            };

            //Cadastro dos itens de pedidos
            ItemPedido itemVejaBanheiro = new ItemPedido()
            {
                IdItemPedido = 1,
                QuantidadeProduto = 4,
                Produto = vejaBanheiro,
                ValorTotalItemPedido = 16                
            };

            ItemPedido itemOmo = new ItemPedido()
            {
                IdItemPedido = 2,
                QuantidadeProduto = 8,
                Produto = omo
            };

            ItemPedido itemVejaLoucas = new ItemPedido()
            {
                IdItemPedido = 3,
                QuantidadeProduto = 2,
                Produto = vejaLoucas
            };

            //Cadastro do pedido
            StatusPedido statusPedido = new StatusPedido()
            {
                IdStatus = 1,
                NomeStatus = "Em Faturamento"

            };

            Pedido pedido = new Pedido()
            {
                IdPedido = 1,
                DataPedido = new DateTime(2017, 02, 01),
                Cliente = cliente
            };

            //Cadastro do fornecedor
            StatusFornecedor statusFornecedor = new StatusFornecedor()
            {
                IdStatus = 1,
                NomeStatus = "Bom"
            };

            Fornecedor limpeMais = new Fornecedor()
            {
                IdFornecedor = 1,
                CNPJ = "123",
                NomeFantasia = "Limpe Mais",
                RazaoSocial = "Limpe Mais",
                StatusFornecedor = statusFornecedor
            };

            Fornecedor limpezaTotal = new Fornecedor()
            {
                IdFornecedor = 1,
                CNPJ = "123",
                NomeFantasia = "Limpeza Total",
                RazaoSocial = "Limpeza Total LTDA",
                StatusFornecedor = statusFornecedor
            };

            //Implementação de Listas

            //Telefone
            contato.ListaDeTelefones.Add(telefone);

            //Produtos
            banheiros.ListaDeProduto.Add(vejaBanheiro);
            lavanderia.ListaDeProduto.Add(omo);
            loucas.ListaDeProduto.Add(vejaLoucas);

            //Item Pedido
            pedido.ListaDeItemPedido.Add(itemVejaBanheiro);
            pedido.ListaDeItemPedido.Add(itemOmo);
            pedido.ListaDeItemPedido.Add(itemVejaLoucas);

            //Pedido Cliente
            cliente.ListaDePedido.Add(pedido);

            //Veja Limpeza Total
            vejaBanheiro.ListaDeProdutos.Add(vejaBanheiro);
            vejaBanheiro.ListaDeItemDoPedido.Add(itemVejaBanheiro);
            vejaBanheiro.ListaDeFornecedores.Add(limpeMais);

            //Sabão em pó - OMO
            omo.ListaDeProdutos.Add(omo);
            omo.ListaDeItemDoPedido.Add(itemOmo);
            omo.ListaDeFornecedores.Add(limpeMais);

            //Veja Multiuso
            vejaLoucas.ListaDeProdutos.Add(vejaLoucas);
            vejaLoucas.ListaDeItemDoPedido.Add(itemVejaLoucas);
            vejaLoucas.ListaDeFornecedores.Add(limpeMais);
            vejaLoucas.ListaDeFornecedores.Add(limpezaTotal);

            return itemVejaBanheiro;
        }
    }
}
