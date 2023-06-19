namespace FestaInfantil.Dominio.Compartilhado
{
    public abstract class EntidadeBase<TEntidade>
    {
        public int id;

        public EntidadeBase()
        {
            
        }

        public abstract void AtualizarInformacoes(TEntidade registroAtualizado);

        public abstract string[] Validar();
    }
}
