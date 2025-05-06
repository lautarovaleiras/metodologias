using metodologias.adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodologias.command
{
    class OrdenLlegaAlumno: IOrdenEnAula2
    {
        Aula aula;
        public OrdenLlegaAlumno(Aula aula)
        {
            this.aula = aula;
        }
        public void ejecutar(IAlumno c)
        {
            Console.WriteLine
                ("El alumno ha llegado");
            aula.nuevoAlumno(c);
            // Implementar la lógica para manejar la llegada de un alumno
            // Por ejemplo, agregar el alumno a una lista o realizar alguna acción específica
           // Console.WriteLine("El alumno ha llegado: " + c.getNombre());
        }
    }
}
