using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestaInfantil.ModuloClientes
{
    public class RepositorioCliente
    {
        List <Cliente> clientes = new List<Cliente>();
        private static int contador;
        public void Inserir(Cliente cliente)
        {
            contador++;
            cliente.id = contador;
            clientes.Add(cliente);
        }
        public void Editar(Cliente cliente)
        {
            Cliente clienteSelecionado = SelecionarPorId(cliente.id);

            clienteSelecionado.nome = cliente.nome;
            clienteSelecionado.telefone = cliente.telefone;
            clienteSelecionado.cpf = cliente.cpf;
        }

        public Cliente SelecionarPorId(int id)
        {
            return clientes.FirstOrDefault(x=> x.id == id);
        }

        public List<Cliente> GetClientes() 
        {
            return clientes;
        }

        public void Excluir(Cliente clienteSelecionado)
        {
            clientes.Remove(clienteSelecionado);
        }

        internal List<Cliente> SelecionarTodos()
        {
            return clientes.OrderByDescending(x => x.id).ToList();
        }
    }
}
