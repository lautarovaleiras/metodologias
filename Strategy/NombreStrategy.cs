
using metodologias.proyecto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace metodologias.Strategy
{
    class NombreStrategy : IComparadorAlumnoStrategy
    {
        public bool sosIgual(Alumno a1, Alumno a2)
        {
            int resul = a1.getNombre().CompareTo(a2.getNombre());
            return resul == 0;
        }

        public bool sosMayor(Alumno a1, Alumno a2)
        {
            int resul = a1.getNombre().CompareTo(a2.getNombre());
            return resul > 0;
        }   

        public bool sosMenor(Alumno a1, Alumno a2)
        {
            int resul = a1.getNombre().CompareTo(a2.getNombre());
            return resul < 0;
        }
    }
}
