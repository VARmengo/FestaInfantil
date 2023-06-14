using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FestaInfantil
{
    public partial class FormTema : Form
    {
        public FormTema()
        {
            InitializeComponent();
            controlBotoes.btnSair.Click += btnSair_Click;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormTema_Load(object sender, EventArgs e)
        {

        }
    }
}
