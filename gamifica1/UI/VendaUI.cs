using gamifica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace gamifica.UI
{
    public class VendaUI
    {
        private List<Venda> vendas = new List<Venda>(); // Adiciona uma lista de vendas como membro da classe

        public void RegistrarVenda(Cliente cliente, List<Produto> produtosVendidos)
        {
            Venda venda = new Venda();
            venda.Cliente = cliente;
            venda.ProdutosVendidos = produtosVendidos;
            venda.DataVenda = DateTime.Now;
            venda.ValorTotalCompra = produtosVendidos.Sum(p => p.Preco);

            vendas.Add(venda); // Adiciona a venda à lista de vendas
                               // Salvar a venda no banco de dados ou em um arquivo
            Console.WriteLine("Venda registrada com sucesso!");
        }

        public void AlterarVenda(int codigoDaVenda, Cliente novoCliente, List<Produto> novosProdutos)
        {
            // Encontra a venda pelo seu IdVenda
            Venda vendaEncontrada = vendas.FirstOrDefault(v => v.IdVenda == codigoDaVenda);

            if (vendaEncontrada != null)
            {
                // Atualiza os atributos da venda
                vendaEncontrada.Cliente = novoCliente;
                vendaEncontrada.ProdutosVendidos = novosProdutos;
                vendaEncontrada.ValorTotalCompra = novosProdutos.Sum(p => p.Preco);

            }
        }




        public List<Venda> BuscarTodasVendas()
        {
            return vendas;
        }


        public Venda BuscarVendaPorId(int id)
        {
            // Encontra a venda pelo seu IdVenda
            Venda vendaEncontrada = vendas.FirstOrDefault(v => v.IdVenda == id);
            if(vendaEncontrada != null)
            {
                return vendaEncontrada;
            }
            return null;
        }

        public void RemoverVenda(int idvenda)
        {
            // Encontra a venda pelo seu IdVenda
            Venda vendaEncontrada = vendas.FirstOrDefault(v => v.IdVenda == idvenda);

            if (vendaEncontrada != null)
            {
                // Remove a venda da lista de vendas
                vendas.Remove(vendaEncontrada);
            }
        }


    }
}
