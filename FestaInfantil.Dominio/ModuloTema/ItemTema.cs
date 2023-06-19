namespace FestaInfantil.Dominio.ModuloTema
{
    public class ItemTema
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        public ItemTema(string nome)
        {
            Nome = nome;
            Preco = 100;
        }

        public override string ToString()
        {
            return Nome + " R$ " + Preco;
        }
    }
}
