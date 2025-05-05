using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using metodologias.adapter;
using metodologias.decorator;
using metodologias.observer;
using metodologias.Strategy;

namespace metodologias.proyecto
{
    public class Alumno : Persona, IObservador, IObservado, IAlumno
    {
        Random r = new Random();
        double promedio;
        int legajo;
        double calificacion;

        List<IObservador> AlumnosFavoritoObservando = new List<IObservador>();
        public bool distrayendose = true;


        IComparadorAlumnoStrategy strategy = new LegajoStrategy();
        public Alumno(string n, int d, double p, int l): base(n,d)
        {
            this.promedio = p;
            this.legajo = l;
        }
        public double getCalificacion()
        {
            return this.calificacion;
        }

        public void setCalificacion(double c)
        {
            this.calificacion = c;
        }

        public virtual int responderPregunta(int pregunta)
        {
            return r.Next(1, 3); // Respuesta aleatoria entre 1 y 3
        }

        public string mostrarCalificacion()
        {
            return this.nombre + "\t" + this.calificacion;
        }

        public void setEstrategia(IComparadorAlumnoStrategy s)
        {
            this.strategy = s;
        }
        public int getLegajo()
        {
            return this.legajo;
        }

        public double getPromedio()
        {
            return this.promedio;
        }
        override
        public bool sosIgual(IComparable c)
        { 

            return this.strategy.sosIgual(this, (IAlumno)c);
        }
        override
        public bool sosMenor(IComparable c)
        {
            return this.strategy.sosMenor(this, (IAlumno)c);

        }
        override
        public bool sosMayor(IComparable c)
        {
            return this.strategy.sosMayor(this, (Alumno)c);

        }

        public override string ToString()
        {
            return string.Format("[Persona: Nombre={0}, Dni={1}, Promedio={2}, Legajo={3}]", nombre, dni, promedio, legajo);
        }

        public void prestarAtencion()
        {
            Console.WriteLine("El alumno " + this.nombre + " está prestando atención.");
            this.distrayendose = false;
        }

        public virtual void distraerse()
        {
            Console.WriteLine("El alumno " + this.nombre + " se está distrayendo.");
            this.distrayendose = true;
            ((IObservado)this).notificar();
        }

        void IObservador.actualizar(IObservado o)
        {
            Profesor p = (Profesor)o;
            if (p.hablando)
            {
                this.prestarAtencion();
            }
            else
            {
                this.distraerse();
            }
        }

        public void agregarObservador(IObservador o)
        {
            AlumnosFavoritoObservando.Add(o);

        }

        public void quitarObservador(IObservador o)
        {
            AlumnosFavoritoObservando.Remove(o);
        }

        public void notificar()
        {
            foreach (IObservador o in AlumnosFavoritoObservando)
            {
                o.actualizar(this);
            }
        }

        int IAlumno.getCalificacion()
        {
            return (int)this.getCalificacion();
        }

        public void setCalificacion(int cal)
        {
           this.setCalificacion((double)cal);
        }
    }
}
