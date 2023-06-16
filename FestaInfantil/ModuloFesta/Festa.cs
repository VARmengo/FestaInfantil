using FestaInfantil.Compartilhado;
using FestaInfantil.ModuloTema;

namespace FestaInfantil.ModuloFesta
{
    public class Festa : EntidadeBase<Festa>
    {
        public Tema tema;

        public override void AtualizarInformacoes(Festa registroAtualizado)
        {
            throw new NotImplementedException();
        }

        public override string[] Validar()
        {
            throw new NotImplementedException();
        }
    }
}
