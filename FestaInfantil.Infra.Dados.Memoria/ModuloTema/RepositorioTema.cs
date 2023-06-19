using FestaInfantil.Dominio.ModuloTema;

namespace FestaInfantil.Infra.Dados.ModuloTema
{
    public class RepositorioTema : RepositorioBase<Tema>
    {
        public RepositorioTema(List<Tema> temas)
        {
            this.listaRegistros = temas;
        }
    }
}
