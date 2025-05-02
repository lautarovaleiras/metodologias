using System.Collections.Generic;
using System.Linq;
using System.Text;
using metodologias.proyecto;

namespace metodologias.Iterator
{
    class IteradorDeConjuntos : IIterador
    {
        Conjunto conjunto;

        int itemActual;

        public IteradorDeConjuntos(Conjunto c)
        {
            this.conjunto = c;
            this.itemActual = 0;
        }
        public IComparable actual()

        {

            return this.conjunto.getElementos()[this.itemActual];
        }

        public bool fin()
        {

            return this.conjunto.cuantos() == this.itemActual;
        }

        public void primero()
        {
            this.itemActual = 0;
        }

        public void siguiente()
        {
            if (!this.fin())
            {
                this.itemActual++;

            }
        }


    }
}
