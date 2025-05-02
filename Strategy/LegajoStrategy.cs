using metodologias.proyecto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace metodologias.Strategy
{
    class LegajoStrategy : IComparadorAlumnoStrategy
    {
        public bool sosIgual(Alumno a1, Alumno a2)
        {
            return a1.getLegajo() == a2.getLegajo();
        }

        public bool sosMayor(Alumno a1, Alumno a2)
        {
            return a1.getLegajo() > a2.getLegajo();
        }

        public bool sosMenor(Alumno a1, Alumno a2)
        {
            return a1.getLegajo() < a2.getLegajo();
        }
    }
}
