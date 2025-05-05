using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodologias.proyecto
{
    public class AlumnoMuyEstudioso: Alumno
    {
        public AlumnoMuyEstudioso(string n, int d, double p, int l) : base(n, d, p, l)
        {
        }
        public override int responderPregunta(int pregunta)
        {
            return pregunta;
        }
    }
}
