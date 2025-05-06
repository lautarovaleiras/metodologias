using metodologias.adapter;
using metodologias.factory;
using metodologias.proyecto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodologias.command
{
    class Aula
    {
        Teacher teacher;

        public void comenzar()
        {
            Console.WriteLine("Comenzando la clase..., creando teacher");
            teacher = new Teacher();
        }

        public void nuevoAlumno(IAlumno a)
        {
            teacher.goToClass(new AlumnoAdapter(a));
        }

        public void claseLista()
        {
            Console.WriteLine("Aula llena");
            teacher.teachingAClass();
        }
    }
}
