using gamifica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gamifica.UI
{
    public class ClienteUI
    {
        private List<Cliente> clientes = new List<Cliente>();
        public void RegistrarCliente(string nome, string sobrenome, string endereco, string telefone)
        {
            Cliente cliente = new Cliente();
            cliente.Nome = nome;
            cliente.Sobrenome = sobrenome;
            cliente.Endereco = endereco;
            cliente.Telefone = telefone;
            clientes.Add(cliente);
            // Salvar o cliente no banco de dados ou em um arquivo
        }

        public void AlterarCliente(int clientee,string nome, string sobrenome, string endereco, string telefone)
        {
            Cliente cliente = clientes.FirstOrDefault(v => v.IdCliente == clientee);

            if (cliente != null)
            {
                // Atualiza os atributos da venda
                cliente.Nome = nome;
                cliente.Sobrenome = sobrenome;
                cliente.Endereco = endereco;
                cliente.Telefone = telefone;

            }
        }

        public List<Cliente> BuscarTodosClientes()
        {
            return clientes;
        }

        public Cliente BuscarClientePorId(int id)
        {
            Cliente clienteEncontrado = clientes.FirstOrDefault(v => v.IdCliente == id);
            if (clienteEncontrado != null)
            {
                return clienteEncontrado;
            }
            return null;
        }

        public void RemoverCliente(int idcliente)
        {
            // Encontra a venda pelo seu IdVenda
            Cliente vendaEncontrada = clientes.FirstOrDefault(v => v.IdCliente == idcliente);

            if (vendaEncontrada != null)
            {
                // Remove a venda da lista de vendas
                clientes.Remove(vendaEncontrada);
            }
        }
    }

}
