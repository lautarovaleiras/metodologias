using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodologias.command
{
    class OrdenAulaLlena: IOrdenEnAula1
    {
        private Aula aula;

        public OrdenAulaLlena(Aula aula)
        {
            this.aula = aula;
        }
        public void ejecutar()
        {
            this.aula.claseLista();
        }
    }
}
