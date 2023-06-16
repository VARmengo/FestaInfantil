using FestaInfantil.Compartilhado;
using FestaInfantil.ModuloFesta;
using FestaInfantil.ModuloTema;

namespace FestaInfantil.ModuloAluguel
{
    public class Aluguel : EntidadeBase<Aluguel>
    {       
        public double valorServico = 150;

        public Festa festa;

        public Tema tema;

        public TipoCliente tipoCliente;

        public Aluguel(Tema tema)
        {
            this.tema = tema;
        }

        public override void AtualizarInformacoes(Aluguel registroAtualizado)
        {
            throw new NotImplementedException();
        }

        public override string[] Validar()
        {
            throw new NotImplementedException();
        }
    }
}
