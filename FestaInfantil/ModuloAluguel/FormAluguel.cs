using FestaInfantil.ModuloTema;

namespace FestaInfantil.ModuloAluguel
{
    public partial class FormAluguel : Form
    {
        public FormAluguel(List<Tema> festas)
        {
            InitializeComponent();

            foreach (Tema festa in festas)
            {
                cmbFesta.Items.Add(festa);
            }
        }

        public Aluguel ObterAluguel()
        {
            int id = Convert.ToInt32(txtId.Text);

            TipoCliente tipoCliente = rdbClienteAntigo.Checked ? TipoCliente.Antigo : TipoCliente.Novo;

            Tema tema = (Tema)cmbFesta.SelectedItem;

            double valorAluguel;
            if (rdbClienteAntigo.Checked)
            {

            }

            else if (rdbClienteNovo.Checked)
            {

            }

            return new Aluguel(tema);
        }
    }
}
