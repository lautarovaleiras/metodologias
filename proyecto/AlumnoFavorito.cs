using metodologias.observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodologias.proyecto
{
    public class AlumnoFavorito : Alumno, IObservador, IObservado
    {
        List<IObservador> profesorObservando = new List<IObservador>();
        public bool avisarProfesor = false;
        public AlumnoFavorito(string n, int d, double p, int l) : base(n, d, p, l)
        {
        }

        public override void distraerse()
        {
            Console.WriteLine("Yo nunca me distraigo siempre presto atencion");
        }

        void IObservador.actualizar(IObservado o)
        {
            if (o is Alumno)
            {
                Alumno a = (Alumno)o;
                if (a.distrayendose)
                {
                    Console.WriteLine("PROFEEE, NO ESTAN PRESTANDO ATENCION");
                    this.avisarProfesor = true;
                }
                else
                {
                    this.distraerse();
                    this.avisarProfesor = false;
                }
            }


        }
        void IObservado.agregarObservador(IObservador o)
        {
            profesorObservando.Add(o);
        }

        void IObservado.quitarObservador(IObservador o)
        {
            profesorObservando.Remove(o);
        }

        void IObservado.notificar()
        {
            foreach (IObservador o in profesorObservando)
            {
                o.actualizar(this);
            }
        }
    }
}
