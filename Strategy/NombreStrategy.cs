
using metodologias.adapter;
using metodologias.proyecto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace metodologias.Strategy
{
    class NombreStrategy : IComparadorAlumnoStrategy
    {
        public bool sosIgual(IAlumno a1, IAlumno a2)
        {
            int resul = a1.getNombre().CompareTo(a2.getNombre());
            return resul == 0;
        }

        public bool sosMayor(IAlumno a1, IAlumno a2)
        {
            int resul = a1.getNombre().CompareTo(a2.getNombre());
            return resul > 0;
        }   

        public bool sosMenor(IAlumno a1, IAlumno a2)
        {
            int resul = a1.getNombre().CompareTo(a2.getNombre());
            return resul < 0;
        }
    }
}
