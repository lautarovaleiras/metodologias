using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace metodologias.proyecto
{
   public abstract class Persona: IComparable
    {
        protected string nombre;
        protected int dni;

        public Persona(string n, int d)
        {
            this.nombre = n;
            this.dni = d;
        }

        public  string getNombre()
        {
            return this.nombre;
        }
        public  int getDni()
        {
            return this.dni;
        }

        public virtual bool sosIgual(IComparable c)
        {
            if (c is Persona p)
                return this.dni == p.getDni();
            else
                return false;
        }

        public virtual bool sosMenor(IComparable c)
        {
            if (c is Persona p)
                return this.dni > p.getDni();
            else
                return false;
        }

        public virtual bool sosMayor(IComparable c)
        {
            if (c is Persona p)
                return this.dni < p.getDni();
            else
                return false;
        }
        public override string ToString()
        {
            return string.Format("[Persona: Nombre={0}, Dni={1}]", nombre, dni);
        }
    }
}
