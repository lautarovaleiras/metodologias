using metodologias.adapter;
using metodologias.proyecto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodologias.decorator
{
    public class DecoradorLegajo : CalificacionesDecorator
    {
        public DecoradorLegajo(IAlumno a) : base(a)
        {
        }

        public override string mostrarCalificacion()
        {
            string resultado = base.mostrarCalificacion();
            resultado = resultado.Insert(resultado.IndexOf('\t'), " (" + base.getLegajo() + ")");
            return resultado;
        }

        internal proyecto.IComparable getAlumno()
        {
            return alumno;
        }
    }
}
