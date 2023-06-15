using FestaInfantil.Compartilhado;

namespace FestaInfantil.ModuloTema
{
    public class Tema : EntidadeBase<Tema>
    {
        public string tema;

        public Tema(string tema)
        {
            this.tema = tema;
        }

        public override void AtualizarInformacoes(Tema registroAtualizado)
        {
            this.tema = registroAtualizado.tema;
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
