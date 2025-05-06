using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodologias.command
{
    class OrdenInicio: IOrdenEnAula1
    {
        Aula aula;

        public OrdenInicio(Aula aula)
        {
            this.aula = aula;
        }
        public void ejecutar()
        {
            Console.WriteLine("Ejecutando orden de inicio...");
            aula.comenzar();
        }
    }

}
