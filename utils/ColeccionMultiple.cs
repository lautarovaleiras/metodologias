using metodologias.Iterator;
using metodologias.proyecto;

namespace metodologias.utils
{
    class ColeccionMultiple: IColeccionable
    {
        Pila pila;
        Cola cola;
        public ColeccionMultiple(IColeccionable p, IColeccionable c)
        {
            this.pila = (Pila)p;
            this.cola = (Cola)c;
        }

        public void agregar(IComparable c)
        {
            System.Console.WriteLine("El programa finalizó correctamente.\n");

        }

        public bool contiene(proyecto.IComparable c)
        {
            return this.pila.contiene(c) || this.cola.contiene(c);
        }

        public int cuantos()
        {
            return this.pila.cuantos() + this.cola.cuantos();
        }

        public IIterador iterador()
        {
            throw new System.NotImplementedException();
        }

        public proyecto.IComparable maximo()
        {
            IComparable colaM = this.cola.maximo();
            IComparable pilaM = this.pila.maximo();
            if (pilaM.sosMayor(colaM))
            {
                return pilaM;
            }
            else
            {
                return colaM;
            }
        }

        public proyecto.IComparable minimo()
        {
            IComparable colaM = this.cola.minimo();
            IComparable pilaM = this.pila.minimo();
            if (pilaM.sosMenor(colaM))
            {
                return pilaM;
            }
            else
            {
                return colaM;
            }
        }
    }
}
