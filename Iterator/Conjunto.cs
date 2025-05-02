using System.Collections.Generic;
using System.Linq;
using System.Text;
using metodologias.proyecto;

namespace metodologias.Iterator
{
    class Conjunto: IColeccionable, IIterable
    {
        private List<IComparable> elementos;

        public Conjunto()
        {
            elementos = new List<IComparable>();

        }
        public List<IComparable> getElementos()
        {
            return this.elementos;
        }
        public void agregar(IComparable c)
        {
            if (!elementos.Contains(c))
            {
                this.elementos.Add(c);
            }
        }

        public bool contiene(IComparable c)
        {
            foreach (var element in this.elementos)
            {
                if (element.sosIgual(c))
                {
                    return true;
                }
            }
            return false;

        }

        public int cuantos()
        {
            return elementos.Count;
        }


        public IComparable maximo()
        {
            if (elementos.Count == 0)
            {
                System.Console.WriteLine("La colección está vacía.");
                return null;
            }
            else
            {
                IComparable mayor = elementos[0];
                foreach (var elemento in elementos)
                {
                    if (elemento.sosMayor(mayor))
                    {
                        mayor = elemento;
                    }
                }
                return mayor;
            }
        }

        public IComparable minimo()
        {
            if (elementos.Count == 0)
            {
                System.Console.WriteLine("La colección está vacía.");
                return null;
            }
            else
            {
                IComparable menor = elementos[0];
                foreach (var elemento in elementos)
                {
                    if (elemento.sosMenor(menor))
                    {
                        menor = elemento;
                    }
                }
                return menor;
            }
        }

        IIterador IIterable.iterador()
        {
            return new IteradorDeConjuntos(this);
        }
    }
}
