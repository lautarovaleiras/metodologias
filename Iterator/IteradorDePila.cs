using System.Collections.Generic;
using System.Linq;
using System.Text;
using metodologias.utils;
using metodologias.proyecto;

namespace metodologias.Iterator
{
    class IteradorDePila: IIterador
    {
        Pila pila;

        int itemActual;
        public IteradorDePila(Pila p)
        {
            this.pila = p;
            this.itemActual = 0;

        }
        public IComparable actual()
        {
            return this.pila.getElementos()[this.itemActual];
        }

        public bool fin()
        {
            return this.pila.cuantos() == (this.itemActual + 1);
        }

        public void primero()
        {
            this.itemActual = 0;
        }

        public void siguiente()
        {
            this.itemActual++;
        }
    }
}
