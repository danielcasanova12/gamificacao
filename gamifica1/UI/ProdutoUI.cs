using gamifica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gamifica.UI
{
    public class ProdutoUI
    {
        private List<Produto> produtos = new List<Produto>();

        public void RegistrarProduto(Produto produto)
        {
            produtos.Add(produto); 
        }

        public void AtualizarProduto(Produto produtoAlterar)
        {
            Produto produtoEncontrado = produtos.FirstOrDefault(p => p.IdProduto == produtoAlterar.IdProduto);
            if (produtoEncontrado != null)
            {
                produtoEncontrado.Nome = produtoAlterar.Nome;
                produtoEncontrado.Descricao = produtoAlterar.Descricao;
                produtoEncontrado.Preco = produtoAlterar.Preco;
                produtoEncontrado.Categoria = produtoAlterar.Categoria;
            }
        }
            public List<Produto> BuscarTodosProdutos()
        {
            return produtos;
        }

        public Produto BuscarProdutoPorId(int id)
        {
            Produto produtoEncontrado = produtos.FirstOrDefault(p => p.IdProduto == id);

            if (produtoEncontrado != null)
            {
                return produtoEncontrado;
            }

            return null;
        }

        public bool RemoverProduto(int codigoDoProduto)
        {
            Produto produtoEncontrado = produtos.FirstOrDefault(p => p.IdProduto == codigoDoProduto);

            if (produtoEncontrado != null)
            {
                produtos.Remove(produtoEncontrado);
                return true;
            }
            return false;
        }

    }
}
