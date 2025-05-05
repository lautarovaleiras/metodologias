using metodologias.adapter;
using metodologias.proyecto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace metodologias.Strategy
{
    class DniStrategy : IComparadorAlumnoStrategy
    {
        public bool sosIgual(IAlumno a1, IAlumno a2)
        {
            return a1.getDni() == a2.getDni();
        }

        public bool sosMayor(IAlumno a1, IAlumno a2)
        {
            return a1.getDni() > a2.getDni();
        }

        public bool sosMenor(IAlumno a1, IAlumno a2)
        {
            return a1.getDni() < a2.getDni();
        }
    }
}
