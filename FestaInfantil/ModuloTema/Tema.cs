using FestaInfantil.Compartilhado;

namespace FestaInfantil.ModuloTema
{
    public class Tema : EntidadeBase<Tema>
    {
        public string tema;
        public List<ItemTema> itemsDeTema;

        public Tema(string tema)
        {
            this.tema = tema;
            this.itemsDeTema = new List<ItemTema>();
        }

        public override void AtualizarInformacoes(Tema registroAtualizado)
        {
            this.tema = registroAtualizado.tema;
            this.itemsDeTema.Clear();
            this.itemsDeTema = registroAtualizado.itemsDeTema;
        }

        public override string ToString()
        {
            return "Id: " + id + " Tema: " + tema;
        }

        public override string[] Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(tema))
                erros.Add("O campo 'tema' é obrigatório");

            return erros.ToArray();
        }
    }
}
