using System.Collections.Generic;
using System.Linq;
using System.Text;
using metodologias.proyecto;
using metodologias.utils;
namespace metodologias.Iterator
{
    class IteradorDeCola : IIterador
    {
        Cola cola;

        int itemActual;
        public IteradorDeCola(Cola c)
        {
            this.cola = c;
            this.itemActual = 0;

        }
        public IComparable actual()
        {
            return this.cola.getElementos()[this.itemActual];
        }

        public bool fin()
        {
            return this.cola.cuantos() == (this.itemActual + 1);
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
