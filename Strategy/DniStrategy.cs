using metodologias.proyecto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace metodologias.Strategy
{
    class DniStrategy : IComparadorAlumnoStrategy
    {
        public bool sosIgual(Alumno a1, Alumno a2)
        {
            return a1.getDni() == a2.getDni();
        }

        public bool sosMayor(Alumno a1, Alumno a2)
        {
            return a1.getDni() > a2.getDni();
        }

        public bool sosMenor(Alumno a1, Alumno a2)
        {
            return a1.getDni() < a2.getDni();
        }
    }
}
