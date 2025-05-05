using metodologias.proyecto;
using metodologias.Strategy;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodologias.adapter
{
    public interface IAlumno : IComparable
    {
        void setEstrategia(IComparadorAlumnoStrategy nvaEstrategia);
        int getLegajo();
        double getPromedio();
        string getNombre();
        int getDni();

        bool sosIgual(IComparable c);

        bool sosMenor(IComparable c);

        bool sosMayor(IComparable c);


        int getCalificacion();
        void setCalificacion(int cal);
        int responderPregunta(int pregunta);
        string mostrarCalificacion();
    }
}
