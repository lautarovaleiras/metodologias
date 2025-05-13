using metodologias.composite;
using metodologias.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodologias.adapter
{
    internal class AlumnoCompuestoAdapter: IAlumno
    {
        private AlumnoCompuesto alumnoCompuesto;
        public AlumnoCompuestoAdapter(AlumnoCompuesto a)
        {
            this.alumnoCompuesto = a;
        }

        public AlumnoCompuesto getAlumnoCompuesto()
        {
            return this.alumnoCompuesto;
        }

        public int getCalificacion()
        {
            return this.alumnoCompuesto.getCalificacion();
        }

        public int getDni()
        {
            return this.alumnoCompuesto.getDni();
        }

        public int getLegajo()
        {
            return this.alumnoCompuesto.getLegajo();
        }

        public string getNombre()
        {
            return this.alumnoCompuesto.getNombre();
        }

        public double getPromedio()
        {
            return this.alumnoCompuesto.getPromedio();
        }

        public string mostrarCalificacion()
        {
            return this.alumnoCompuesto.mostrarCalificacion();
        }

        public int responderPregunta(int pregunta)
        {
           return this.alumnoCompuesto.responderPregunta(pregunta);
        }

        public void setCalificacion(int cal)
        {
            this.alumnoCompuesto.setCalificacion(cal);
        }

        public void setEstrategia(IComparadorAlumnoStrategy nvaEstrategia)
        {
            this.alumnoCompuesto.setEstrategia(nvaEstrategia);
        }

        public bool sosIgual(proyecto.IComparable c)
        {
            return this.alumnoCompuesto.sosIgual(c);
        }

        public bool sosMayor(proyecto.IComparable c)
        {
            return this.alumnoCompuesto.sosMayor(c);
        }

        public bool sosMenor(proyecto.IComparable c)
        {
            return this.alumnoCompuesto.sosMenor(c);
        }
    }
}
