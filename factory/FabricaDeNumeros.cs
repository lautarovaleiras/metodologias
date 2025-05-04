using metodologias.proyecto;
using metodologias.utils;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodologias.factory
{
    public class FabricaDeNumeros : FabricaDeComparables
    {
        public override IComparable crearAleatorio()
        {
            return new Numero(generador.numeroAleatoreo(1000));
        }
        public override IComparable crearPorTeclado()
        {
            return new Numero(lector.numeroPorTeclado());
        }
    }
}
