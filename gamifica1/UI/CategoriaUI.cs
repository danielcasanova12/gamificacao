using gamifica.Models;
using System.Collections.Generic;
using System.Linq;

namespace gamifica.UI
{
    public class CategoriaUI
    {
        private List<Categoria> categorias = new List<Categoria>();

        public void RegistrarCategoria(Categoria categoria)
        {
            categorias.Add(categoria);

            // Salvar a categoria no banco de dados ou em um arquivo
        }

        public void AlterarCategoria(Categoria categoriaAlterar)
        {
            Categoria categoriaEncontrada = categorias.FirstOrDefault(c => c.IdCategoria == categoriaAlterar.IdCategoria);
            if (categoriaEncontrada != null)
            {
                categoriaEncontrada.Nome = categoriaAlterar.Nome;
                categoriaEncontrada.Descricao = categoriaAlterar.Descricao;
            }
        }

        public List<Categoria> BuscarTodasCategorias()
        {
            return categorias;
        }

        public Categoria BuscarCategoriaPorId(int id)
        {
            Categoria categoriaEncontrada = categorias.FirstOrDefault(c => c.IdCategoria == id);

            if (categoriaEncontrada != null)
            {
                return categoriaEncontrada;
            }

            return null;
        }

        public bool RemoverCategoria(int id)
        {
            Categoria categoriaEncontrada = categorias.FirstOrDefault(c => c.IdCategoria == id);

            if (categoriaEncontrada != null)
            {
                categorias.Remove(categoriaEncontrada);
                return true;
            }
            return false;
        }
    }
}
