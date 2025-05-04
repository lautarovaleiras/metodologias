using metodologias.proyecto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodologias.Strategy
{
    internal class AntiguedadStrategy: IComparadorProfesorStrategy
    {
        public bool sosIgual(Profesor p1, Profesor p2)
        {
            return p1.getAntiguedad() == p2.getAntiguedad();
        }
        public bool sosMenor(Profesor p1, Profesor p2)
        {
            return p1.getAntiguedad() < p2.getAntiguedad();
        }
        public bool sosMayor(Profesor p1, Profesor p2)
        {
            return p1.getAntiguedad() > p2.getAntiguedad();
        }
    }

}
