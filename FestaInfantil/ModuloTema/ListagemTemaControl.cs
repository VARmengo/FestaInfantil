

namespace FestaInfantil.ModuloTema
{
    public partial class ListagemTemaControl : UserControl
    {
        public ListagemTemaControl()
        {
            InitializeComponent();
        }

        public void AtualizarRegistros(List<Tema> temas)
        {
            listTemas.Items.Clear();

            foreach (Tema tema in temas)
            {
                listTemas.Items.Add(tema);
            }
        }

        public Tema ObterTemaSelecionado()
        {
            return (Tema)listTemas.SelectedItem;
        }
    }
}
