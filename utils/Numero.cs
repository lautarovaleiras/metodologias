using System.Collections.Generic;
using System.Linq;
using System.Text;
using metodologias.proyecto;

namespace metodologias.utils
{
    class Numero : IComparable
    {
        int valor;

        public Numero(int v)
        {
            this.valor = v;
        }

        public int getNumero()
        {
            return this.valor;
        }

        public bool sosIgual(IComparable c)
        {
            if (c is Numero n)
                return this.valor == n.getNumero();
            else
                return false;
        }

        public bool sosMayor(IComparable c)
        {
            if (c is Numero n)
                return this.valor > n.getNumero();
            else
                return false;
        }

        public bool sosMenor(IComparable c)
        {
            if (c is Numero n)
                return this.valor < n.getNumero();
            else
                return false;
        }

        public override string ToString()
        {
            return string.Format("[Numero: Valor={0}]", this.valor);
        }
    }
}
