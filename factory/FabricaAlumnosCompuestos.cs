using metodologias.adapter;
using metodologias.composite;
using metodologias.proyecto;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodologias.factory
{
    internal class FabricaAlumnosCompuestos : FabricaDeComparables
    {
        public override IComparable crearAleatorio()
        {
            AlumnoCompuesto alumnoCompuesto = new AlumnoCompuesto();
            for (int i = 1; i <= 5; i++)
            {
                IComparable alumno = FabricaDeComparables.crearAleatorio(2);
                alumnoCompuesto.agregarHijo((IAlumno)alumno);

            }
           return new AlumnoCompuestoAdapter(alumnoCompuesto);
        }

        public override IComparable crearPorTeclado()
        {
            return new AlumnoCompuesto();
        }
    }
}
