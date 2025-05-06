using metodologias.proxy;
using metodologias.proyecto;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodologias.factory
{
    class FabricaDeAlumnos: FabricaDeComparables
    {

        public override IComparable crearAleatorio()
        {
            return new AlumnoProxy(generador.stringAleatoreo(4), generador.numeroAleatoreo(100000000), (double)generador.doubleAleatorio(), generador.numeroAleatoreo(99999));
        }

        public override IComparable crearPorTeclado()
        {
            return new Alumno(lector.stringPorTeclado(), lector.numeroPorTeclado(), (double)lector.numeroPorTeclado(), lector.numeroPorTeclado());
        }
    }
}
