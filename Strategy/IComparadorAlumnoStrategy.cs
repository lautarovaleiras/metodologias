using metodologias.proyecto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace metodologias.Strategy
{
    public interface IComparadorAlumnoStrategy
    {
        bool sosIgual(Alumno a1, Alumno a2);
        bool sosMenor(Alumno  a1 , Alumno a2);
        bool sosMayor(Alumno  a1, Alumno a2);
    }
}

