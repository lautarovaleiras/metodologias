using metodologias.proyecto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodologias.Strategy
{
    public interface IComparadorProfesorStrategy
    {
        bool sosIgual(Profesor p1, Profesor p2);
        bool sosMenor(Profesor p1, Profesor p2);
        bool sosMayor(Profesor p1, Profesor p2);
    }
}
