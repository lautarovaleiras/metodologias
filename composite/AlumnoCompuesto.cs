using metodologias.adapter;
using metodologias.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodologias.composite
{
    public class AlumnoCompuesto : IAlumno
    {
        private List<IAlumno> hijos;

        public void agregarHijo(IAlumno hijo)
        {
            if (hijos == null)
            {
                hijos = new List<IAlumno>();
            }
            hijos.Add(hijo);
        }
        public int getCalificacion()
        {
            return 0;
        }

        public int getDni()
        {

            int dni = 0;
            foreach (IAlumno a in hijos)
            {
                dni += a.getDni();
            }
            return dni / hijos.Count;
        }

        public int getLegajo()
        {
            int legajo = 0;
            foreach (IAlumno a in hijos)
            {
                legajo += a.getLegajo();
            }
            return legajo / hijos.Count;

        }

        public string getNombre()
        {
            string nombres = "";
            foreach (IAlumno a in hijos)
            {
                nombres += a.getNombre() + " ";
            }

            return nombres;
        }

        public double getPromedio()
        {

            double promedio = 0;
            foreach (IAlumno a in hijos)
            {
                promedio += a.getPromedio();
            }
            return promedio / hijos.Count;
        }

        public string mostrarCalificacion()
        {
            string calificaciones = "";
            foreach (IAlumno a in hijos)
            {
                calificaciones += a.mostrarCalificacion() + " ";
            }
            return "Calificaciones: " + calificaciones;
        }


        /**
         * devuelve la respuesta más votada por todos los componentes hijos del compuesto
         * (en caso de empate entre dos o más respuestas, se elige una de ellas al azar). 
         * */
        public int responderPregunta(int pregunta)
        {
            // Armar un map con las respuestas mas repetidas
            // y devolver la respuesta mas repetida 
            // o una de ellas al azar
            Dictionary<int, int> respuestas = new Dictionary<int, int>();
            foreach (IAlumno a in hijos)
            {
                int respuesta = a.responderPregunta(pregunta);
                if (respuestas.ContainsKey(respuesta))
                {
                    respuestas[respuesta]++;
                }
                else
                {
                    respuestas[respuesta] = 1;
                }
            }
            return respuestas.OrderByDescending(x => x.Value).First().Key;
        }

        public void setCalificacion(int cal)
        {
            foreach (IAlumno a in hijos)
            {
                a.setCalificacion(cal);
            }
        }

        public void setEstrategia(IComparadorAlumnoStrategy nvaEstrategia)
        {
            throw new NotImplementedException();
        }

        public bool sosIgual(proyecto.IComparable c)
        {
            foreach (IAlumno a in hijos)
            {
                if (a.sosIgual(c))
                {
                    return true;
                }
            }

            return false;
        }

        public bool sosMayor(proyecto.IComparable c)
        {
            bool sonTodosMayores = true;
            foreach (IAlumno a in hijos)
            {
                if (!a.sosMayor(c))
                {
                    sonTodosMayores = false;
                    return sonTodosMayores;
                }
            }
            return sonTodosMayores;
        }

        public bool sosMenor(proyecto.IComparable c)
        {
            bool sonTodosMenores = true;
            foreach (IAlumno a in hijos)
            {
                if (!a.sosMenor(c))
                {
                    sonTodosMenores = false;
                    return sonTodosMenores;
                }
            }
            return sonTodosMenores;
        }
    }
}
