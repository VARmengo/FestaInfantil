namespace FestaInfantil.Compartilhado
{
    public abstract class EntidadeBase
    {
        public int id;

        public EntidadeBase()
        {
            
        }

        public abstract string[] Validar();
    }
}
