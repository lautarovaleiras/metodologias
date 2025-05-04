using metodologias.observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodologias.proyecto
{
    public class Profesor : Persona, IObservado
    {
        List<IObservador> observadores = new List<IObservador>();
        int antiguedad;
        public bool hablando = false;
        public Profesor(string n, int d, int a) : base(n, d)
        {
            this.antiguedad = a;
        }
        void IObservado.agregarObservador(IObservador o)
        {
            observadores.Add(o);
        }

        void IObservado.quitarObservador(IObservador o)
        {
            observadores.Remove(o);
        }

        void IObservado.notificar()
        {
            foreach (IObservador o in observadores)
            {
                o.actualizar(this);
            }
        }
        public int getAntiguedad()
        {
            return this.antiguedad;
        }

        public void hablarALaClase()
        {
            Console.WriteLine("Hola clase, soy el profesor, presten atencion ");
            this.hablando = true;
            ((IObservado)this).notificar();

        }

        public void escribirEnElPizarron()
        {
            Console.WriteLine("El profesor " + this.nombre + " está escribiendo en el pizarrón.");
            this.hablando = false;
            ((IObservado)this).notificar();

        }

        public override string ToString()
        {
            return string.Format("[Persona: Nombre={0}, Dni={1}, antiguedad={2}]", nombre, dni, this.antiguedad);
        }



    }
}
