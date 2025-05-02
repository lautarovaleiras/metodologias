using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using metodologias.Strategy;

namespace metodologias.proyecto
{
    public class Alumno : Persona
    {
        double promedio;
        int legajo;

        IComparadorAlumnoStrategy strategy = new LegajoStrategy();
        public Alumno(string n, int d, double p, int l): base(n,d)
        {
            this.promedio = p;
            this.legajo = l;
        }

        public void setEstrategia(IComparadorAlumnoStrategy s)
        {
            this.strategy = s;
        }
        public int getLegajo()
        {
            return this.legajo;
        }

        public double getPromedio()
        {
            return this.promedio;
        }
        override
        public  bool sosIgual(IComparable c)
        {
            return this.strategy.sosIgual(this, (Alumno)c);
        }
        override
        public bool sosMenor(IComparable c)
        {
            return this.strategy.sosMenor(this, (Alumno)c);

        }
        override
        public bool sosMayor(IComparable c)
        {
            return this.strategy.sosMayor(this, (Alumno)c);

        }

        public override string ToString()
        {
            return string.Format("[Persona: Nombre={0}, Dni={1}, Promedio={2}, Legajo={3}]", nombre, dni, promedio, legajo);
        }

    }
}
