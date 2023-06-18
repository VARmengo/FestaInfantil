using FestaInfantil.Compartilhado;
using FestaInfantil.ModuloClientes;
using FestaInfantil.ModuloFest;
using FestaInfantil.ModuloTema;

namespace FestaInfantil.ModuloAluguel
{
    public class Aluguel : EntidadeBase<Aluguel>
    {        
        public Festa festa;
        public Cliente cliente;
        public Tema tema;
        public TipoCliente tipoCliente;
        public double valorAluguelCompleto;
        public double valorAluguelDesconto;

        public Aluguel(Festa festa, Cliente cliente, Tema tema, TipoCliente tipoCliente, double valorAluguelCompleto, double valorAluguelDesconto)
        {
            this.festa = festa;
            this.cliente = cliente;
            this.tema = tema;
            this.tipoCliente = tipoCliente;
            this.valorAluguelCompleto = valorAluguelCompleto;
            this.valorAluguelDesconto = valorAluguelDesconto;
        }

        public override void AtualizarInformacoes(Aluguel registroAtualizado)
        {
            this.festa = registroAtualizado.festa;
            this.tipoCliente = registroAtualizado.tipoCliente;
            this.valorAluguelCompleto = registroAtualizado.valorAluguelCompleto;
            this.valorAluguelDesconto = registroAtualizado.valorAluguelDesconto;
        }

        public override string[] Validar()
        {
            List<string> erros = new List<string>();

            if (valorAluguelCompleto == 0)
                erros.Add("O valor do aluguel não pode ser zero.");

            if (valorAluguelDesconto > valorAluguelCompleto)
                erros.Add("O valor com desconto não pode ser maior que o valor sem desconto.");

            return erros.ToArray();
        }
    }
}
