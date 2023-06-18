using FestaInfantil.Compartilhado;
using FestaInfantil.ModuloClientes;
using FestaInfantil.ModuloTema;

namespace FestaInfantil.ModuloFest
{
    public class Festa : EntidadeBase<Festa>
    {        
        public string endereco;
        public DateTime dataCriacao;
        public TimeSpan horaInicial;
        public TimeSpan horaFinal;
        public Cliente cliente;
        public Tema tema;

        public Festa(string endereco, DateTime dataCriacao, TimeSpan horaInicial, TimeSpan horaFinal, Cliente cliente, Tema tema)
        {
            this.endereco = endereco;
            this.dataCriacao = dataCriacao;
            this.horaInicial = horaInicial;
            this.horaFinal = horaFinal;
            this.cliente = cliente;
            this.tema = tema;
        }

        public override void AtualizarInformacoes(Festa registroAtualizado)
        {
            this.endereco = registroAtualizado.endereco;
            this.horaInicial = registroAtualizado.horaInicial;
            this.horaFinal = registroAtualizado.horaFinal;
            this.cliente = registroAtualizado.cliente;
            this.tema = registroAtualizado.tema;
        }

        public override string[] Validar()
        {

            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(endereco))
                erros.Add("O campo 'endereco' é obrigatório");

            return erros.ToArray();
        }
    }
}
