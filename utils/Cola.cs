using System.Collections.Generic;
using System.Linq;
using metodologias.proyecto;
using metodologias.Iterator;
using metodologias.command;
using metodologias.adapter;

namespace metodologias.utils
{
    public class Cola : IColeccionable, IIterable, IOrdenable
    {
        private List<IComparable> elementos;

        public Cola()
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

        public IComparable sacar()
        {
            if (elementos.Count == 0)
            {
                System.Console.WriteLine("La cola está vacía.");
                return null;
               // throw new InvalidOperationException("La cola está vacía.");
            }
            IComparable primero = elementos[0];
            elementos.RemoveAt(0); // Elimina el primer elemento
            return primero;
        }
        IIterador IIterable.iterador()
        {
            return new IteradorDeCola(this);
        }

        public void setOrdenInicio(IOrdenEnAula1 orden)
        {
            orden.ejecutar();
        }

        public void setOrdenLlegaAlumno(IOrdenEnAula2 orden)
        {
            orden.ejecutar(this.sacar() as IAlumno);
        }

        public void setOrdenAulaLlena(IOrdenEnAula1 orden)
        {
            orden.ejecutar();
        }
    }
}
