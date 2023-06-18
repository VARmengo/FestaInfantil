namespace FestaInfantil.ModuloTema
{
    public class ItemTema
    {
        public string Nome { get; set; }

        public ItemTema(string nome)
        {
            Nome = nome;
        }

        public override string ToString()
        {
            return Nome;
        }
    }
}
