using metodologias.factory;
using metodologias.proyecto;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodologias.adapter
{
    // Alumno se comporte como un Student
    class AlumnoAdapter : Student
    {
        private IAlumno alumno;

        public AlumnoAdapter(IAlumno a)
        {
            this.alumno = a;
        }

        public IAlumno getAlumno()
        {
            return this.alumno;
        }
        public bool equals(Student student)
        {
            return this.alumno.sosIgual((IComparable)((AlumnoAdapter)student).getAlumno());
        }

        public string getName()
        {
            return this.alumno.getNombre();
        }

        public bool greaterThan(Student student)
        {
            return this.alumno.sosMayor((IComparable)((AlumnoAdapter)student).getAlumno());
        }

        public bool lessThan(Student student)
        {
            return this.alumno.sosMenor((IComparable)((AlumnoAdapter)student).getAlumno());
        }

        public void setScore(int score)
        {
            this.alumno.setCalificacion(score);
        }

        public string showResult()
        {
           return this.alumno.mostrarCalificacion();
        }

        public int yourAnswerIs(int question)
        {
            return this.alumno.responderPregunta(question);
        }
    }
}
