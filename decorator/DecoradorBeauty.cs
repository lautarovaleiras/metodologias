using metodologias.adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodologias.decorator
{
    public class DecoradorBeauty : CalificacionesDecorator
    {
        public DecoradorBeauty(IAlumno a) : base(a)
        {
        }

        public override string mostrarCalificacion()
        {
            return "***" + base.mostrarCalificacion() + "***";
        }
    }
}
