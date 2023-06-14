using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestaInfantil.Compartilhado
{
    public abstract class EntidadeBase
    {
        public int id;

        public EntidadeBase()
        {
            
        }

        public abstract string[] Validar();
    }
}
