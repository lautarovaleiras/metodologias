using metodologias.adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodologias.decorator
{
    public class DecoradorPromocion : CalificacionesDecorator
    {
        public DecoradorPromocion(IAlumno a) : base(a)
        {
        }

        public override string mostrarCalificacion()
        {
            if (alumno.getCalificacion() >= 7)
            {
                return alumno.mostrarCalificacion() + " " + "(Promocionado)";
            }
            else if (alumno.getCalificacion() >= 4 && alumno.getCalificacion() <= 6)
            {
                return alumno.mostrarCalificacion() + " " + "(Aprobado)";
            }
            else
            {
                return alumno.mostrarCalificacion() + " " + "(No Promocionado)";
            }
        }

    }
}
