using metodologias.adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodologias.decorator
{
    public class DecoradorLetras : CalificacionesDecorator
    {
        public DecoradorLetras(IAlumno a) : base(a)
        {
        }

        public override string mostrarCalificacion()
        {
            return base.mostrarCalificacion() + " " + "(" + transformarCalificacionAString(base.getCalificacion()) + ")";
        }

        string transformarCalificacionAString(int calificacion)
        {
            switch (calificacion)
            {
                case 1: return "Uno";
                case 2: return "Dos";
                case 3: return "Tres";
                case 4: return "Cuatro";
                case 5: return "Cinco";
                case 6: return "Seis";
                case 7: return "Siete";
                case 8: return "Ocho";
                case 9: return "Nueve";
                case 10: return "Diez";
                default: return "No válido";
            }
        }
    }
}
