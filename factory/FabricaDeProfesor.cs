using metodologias.proyecto;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodologias.factory
{
    public class FabricaDeProfesor : FabricaDeComparables
    {
        public override IComparable crearAleatorio()
        {
            return new Profesor(generador.stringAleatoreo(4), generador.numeroAleatoreo(100000000), generador.numeroAleatoreo(30));
        }

        public override IComparable crearPorTeclado()
        {
            return new Profesor(lector.stringPorTeclado(), lector.numeroPorTeclado(), lector.numeroPorTeclado());
        }
    }
}
