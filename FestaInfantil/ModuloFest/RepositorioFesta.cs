using FestaInfantil.ModuloClientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestaInfantil.ModuloFest
{
    public class RepositorioFesta
    {
        List<Festa> festas = new List<Festa>();
        private static int contador;
        public void Inserir(Festa festa)
        {
            contador++;
            festa.id = contador;
            festas.Add(festa);
        }
        public void Editar(Festa festa)
        {
            Festa festaSelecionada = SelecionarPorId(festa.id);

            festaSelecionada.endereco = festa.endereco;
            festaSelecionada.dataCriacao = festa.dataCriacao;
            festaSelecionada.horaInicial = festa.horaInicial;
            festaSelecionada.horaFinal = festa.horaFinal;
            festaSelecionada.cliente = festa.cliente;
        }

        public Festa SelecionarPorId(int id)
        {
            return festas.FirstOrDefault(x => x.id == id);
        }

        public List<Festa> GetFestas()
        {
            return festas;
        }

        public void Excluir(Festa festaSelecionada)
        {
           festas.Remove(festaSelecionada);
        }
    }
}
