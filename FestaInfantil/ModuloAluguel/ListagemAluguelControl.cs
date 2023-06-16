namespace FestaInfantil.ModuloAluguel
{
    public partial class listAlugueis : UserControl
    {
        public listAlugueis()
        {
            InitializeComponent();
        }
        public void AtualizarRegistros(List<Aluguel> alugueis)
        {
            listAlugueis.Items.Clear();

            foreach (Aluguel aluguel in alugueis)
            {
                listAlugueis.Items.Add(aluguel);
            }
        }

        public Aluguel ObterAluguelSelecionado()
        {
            return (Aluguel)listAlugueis.SelectedItem;
        }
    }
}
