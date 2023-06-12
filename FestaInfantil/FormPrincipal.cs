namespace FestaInfantil
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnTeste_Click(object sender, EventArgs e)
        {
            FormFesta formFesta = new FormFesta();

            formFesta.ShowDialog();
        }
    }
}