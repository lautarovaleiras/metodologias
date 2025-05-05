using metodologias.proyecto;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodologias.factory
{
    public class FabricaDeAlumnosMuyEstudiosos : FabricaDeComparables
    {
        public override IComparable crearAleatorio()
        {
            return new AlumnoMuyEstudioso(generador.stringAleatoreo(4), generador.numeroAleatoreo(100000000), (double)generador.doubleAleatorio(), generador.numeroAleatoreo(99999));
        }

        public override IComparable crearPorTeclado()
        {
            return new AlumnoMuyEstudioso(generador.stringAleatoreo(4), generador.numeroAleatoreo(100000000), (double)generador.doubleAleatorio(), generador.numeroAleatoreo(99999));
        }
    }
}
