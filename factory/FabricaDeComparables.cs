using metodologias.proyecto;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodologias.factory
{
    public abstract class FabricaDeComparables
    {

        protected GenereadorDeDatosAleatorios generador = new GenereadorDeDatosAleatorios();
        protected LectorDeDatos lector = new LectorDeDatos();

        public static IComparable crearAleatorio(int opcion)
        {
            FabricaDeComparables fabrica = null;
            switch (opcion)
            {
                case 1: fabrica = new FabricaDeNumeros(); break;
                case 2: fabrica = new FabricaDeAlumnos(); break;
                case 3: fabrica = new FabricaDeProfesor(); break;
            }

            return fabrica.crearAleatorio();
        }

        public static IComparable crearPorTeclado(int opcion)
        {
            FabricaDeComparables fabrica = null;
            switch (opcion)
            {
                case 1: fabrica = new FabricaDeNumeros(); break;
                case 2: fabrica = new FabricaDeAlumnos(); break;
                case 3: fabrica = new FabricaDeProfesor(); break;
            }

            return fabrica.crearPorTeclado();
        }

        public abstract IComparable crearAleatorio();

        public abstract IComparable crearPorTeclado();

    }
}
