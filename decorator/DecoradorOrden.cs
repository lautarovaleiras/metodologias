using metodologias.adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodologias.decorator
{
    public class DecoradorOrden : CalificacionesDecorator
    {
        public DecoradorOrden(IAlumno a) : base(a)
        {
        }
    }
}
