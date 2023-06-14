using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestaInfantil.Compartilhado
{
    public abstract class ControladorBase
    {
        public abstract string ToolTipInserir  { get; }
        public abstract string ToolTipEditar { get; }
        public abstract string ToolTipExcluir { get; }

        public abstract void Inserir();
        public abstract void Editar();
        public abstract void Excluir();

        public abstract string ObterTipoCadastro();
        public abstract UserControl ObterListagem();
    }
}
