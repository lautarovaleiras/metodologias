using metodologias.adapter;
using metodologias.proyecto;
using metodologias.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodologias.proxy
{
    public class AlumnoProxy : IAlumno
    {
        Alumno alumnoReal = null;
        string nombre;
        int dni;
        double promedio;
        int legajo;
        double calificacion;

        public AlumnoProxy(string n, int d, double p, int l)
        {
            this.nombre = n;
            this.dni = d;
            this.promedio = p;
            this.legajo = l;
        }
        public int getCalificacion()
        {
            return (int)this.calificacion;
        }

        public int getDni()
        {
            return this.dni;
        }

        public int getLegajo()
        {
            return this.legajo;
        }

        public string getNombre()
        {
            return this.nombre;
        }

        public double getPromedio()
        {
            return this.promedio;
        }

        public string mostrarCalificacion()
        {
            return this.nombre + "\t" + this.calificacion;
        }

        public int responderPregunta(int pregunta)
        {
            if(alumnoReal == null)
            {
                Console.WriteLine("Creando el alumno real...");
                alumnoReal = new Alumno(nombre, dni, promedio, legajo);
            }
           return alumnoReal.responderPregunta(pregunta);
        }

        public void setCalificacion(int cal)
        {
            this.calificacion = cal;
        }

        public void setEstrategia(IComparadorAlumnoStrategy nvaEstrategia)
        {
            alumnoReal.setEstrategia(nvaEstrategia);
        }

        public bool sosIgual(proyecto.IComparable c)
        {
            return alumnoReal.sosIgual(c);
        }

        public bool sosMayor(proyecto.IComparable c)
        {
            return alumnoReal.sosMayor(c);
        }

        public bool sosMenor(proyecto.IComparable c)
        {
            return alumnoReal.sosMenor(c);
        }
    }
}
