using metodologias.adapter;
using metodologias.proyecto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace metodologias.Strategy
{
    class LegajoStrategy : IComparadorAlumnoStrategy
    {
        public bool sosIgual(IAlumno a1, IAlumno a2)
        {
            return a1.getLegajo() == a2.getLegajo();
        }

        public bool sosMayor(IAlumno a1, IAlumno a2)
        {
            return a1.getLegajo() > a2.getLegajo();
        }

        public bool sosMenor(IAlumno a1, IAlumno a2)
        {
            return a1.getLegajo() < a2.getLegajo();
        }
    }
}
