using metodologias.adapter;
using metodologias.proyecto;
using metodologias.Strategy;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodologias.decorator
{
    public abstract class CalificacionesDecorator : IAlumno
    {
        protected IAlumno alumno;
        protected CalificacionesDecorator(IAlumno a)
        {
            this.alumno = a;
        }

        public virtual int getCalificacion()
        {
            return this.alumno.getCalificacion();
        }

        public int getDni()
        {
            return this.alumno.getDni();
        }

        public int getLegajo()
        {
            return this.alumno.getLegajo();
        }

        public string getNombre()
        {
            return this.alumno.getNombre();
        }

        public double getPromedio()
        {
            return this.alumno.getPromedio();
        }

        public virtual string mostrarCalificacion()
        {
            return this.alumno.mostrarCalificacion();
        }

        public int responderPregunta(int pregunta)
        {
            return this.alumno.responderPregunta(pregunta);
        }

        public void setCalificacion(int cal)
        {
           this.alumno.setCalificacion(cal);
        }

        public void setEstrategia(IComparadorAlumnoStrategy nvaEstrategia)
        {
            this.alumno.setEstrategia(nvaEstrategia);
        }

        public bool sosIgual(IComparable c)
        {
            return this.alumno.sosIgual(c);
        }

        public bool sosMayor(IComparable c)
        {
            return this.alumno.sosMayor(c);
        }

        public bool sosMenor(IComparable c)
        {
            return this.alumno.sosMenor(c);
        }
    }
}
