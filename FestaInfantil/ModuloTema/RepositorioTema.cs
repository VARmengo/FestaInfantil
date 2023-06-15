using FestaInfantil.Compartilhado;

namespace FestaInfantil.ModuloTema
{
    public class RepositorioTema : RepositorioBase<Tema>
    {
        public RepositorioTema(List<Tema> temas)
        {
            this.listaRegistros = temas;
        }
    }
}
