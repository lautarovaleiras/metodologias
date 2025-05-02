
using metodologias.proyecto;
using System.Collections.Generic;
using System.Linq;
using metodologias.Iterator;
namespace metodologias.utils
{
    public class Pila : IColeccionable, IIterable
    {
        private List<IComparable> elementos;

        public Pila()
        {
            elementos = new List<IComparable>();
        }

        public List<IComparable> getElementos()
        {
            return this.elementos;
        }

        public int cuantos()
        {
            return elementos.Count;
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

        public void agregar(IComparable c)
        {
            elementos.Add(c); // Agregar al final de la lista
        }

        public bool contiene(IComparable c)
        {
            return elementos.Contains(c);
        }

        public IComparable Sacar()
        {
            if (elementos.Count == 0)
            {
                throw new System.InvalidOperationException("La pila está vacía.");
            }
            IComparable ultimo = elementos[elementos.Count - 1];
            elementos.RemoveAt(elementos.Count - 1); // Elimina el último elemento
            return ultimo;
        }

        public IColeccionable iterador()
        {
            return this;
        }
        IIterador IIterable.iterador()
        {
            return new IteradorDePila(this);
        }
    }
}
