using metodologias.adapter;
using metodologias.proyecto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace metodologias.Strategy
{
    public interface IComparadorAlumnoStrategy
    {
        bool sosIgual(IAlumno a1, IAlumno a2);
        bool sosMenor(IAlumno a1, IAlumno a2);
        bool sosMayor(IAlumno a1, IAlumno a2);
    }
}

