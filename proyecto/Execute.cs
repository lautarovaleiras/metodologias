using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using metodologias.utils;
using metodologias.Iterator;
using metodologias.Strategy;
using metodologias.factory;
using metodologias.observer;
using metodologias.adapter;
using metodologias.decorator;
namespace metodologias.proyecto
{
    class Execute
    {
       static Random random = new Random();
        public static void llenarAlumnos(IColeccionable c)
        {

            for (int i = 1; i<=20; i++)
            {
                const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                int dni = random.Next(1,40);
                double promedio = Math.Round(1 + (random.NextDouble() * 9), 2); // Redondea a 2 decimales
                int legajo = random.Next(1500);
                string nombre = new string(Enumerable.Repeat(chars, 5).Select(s => s[random.Next(s.Length)]).ToArray());;
                Alumno alumno =  new Alumno(nombre, dni, promedio, legajo);
               // Console.WriteLine(alumno.ToString() ) ;
                c.agregar(alumno);
            }
        }

        public static void llenar(IColeccionable c, int opcion)
        {
            for (int i = 1; i <= 20; i++)
            {
                IComparable elemento = FabricaDeComparables.crearAleatorio(opcion);
                c.agregar(elemento);
            }
        }
        public static void cambiarEstrategia(IColeccionable c, IComparadorAlumnoStrategy s)
        {
            IIterador iterador = c.iterador();
            while (!iterador.fin())
            {
                Alumno comp = (Alumno)iterador.actual();
                comp.setEstrategia(s);
                iterador.siguiente();
            }
        }

        public static void dictadoDeClases(Profesor p)
        {
            for (int i = 0; i < 5; i++)
            {

                p.hablarALaClase();
                
                p.escribirEnElPizarron();
            }

        }

        public static void informar(IColeccionable c)
        {
            Console.WriteLine(c.cuantos());
            Console.WriteLine(c.maximo());
            Console.WriteLine(c.minimo());
            LectorDeDatos opcion = new LectorDeDatos();
            IComparable elemento = FabricaDeComparables.crearPorTeclado(opcion.numeroPorTeclado());

            if (c.contiene(elemento))
            {
                Console.WriteLine("El elemento leído está en la colección");
            }
            else
            {
                Console.WriteLine("El elemento leído NO está en la colección");

            }

        }

        public static void imprimirElementos(IColeccionable c)
        {
            IIterador iterador = c.iterador();
            while (!iterador.fin())
            {
                Console.WriteLine(iterador.actual().ToString());

                iterador.siguiente();
            }
        }

        public static void Main(string[] args)
        {
            Student student;
            Teacher teacher = new Teacher();
            IAlumno alumno;
            for (int i = 0; i < 10; i++)
            {
                alumno = (IAlumno)FabricaDeComparables.crearAleatorio(2);
                IAlumno alumnoDecoradoLetras = new DecoradorLetras(alumno);
                IAlumno alumnoDecorado = new DecoradorLegajo(alumnoDecoradoLetras);

                student = new AlumnoAdapter(alumnoDecorado);

                teacher.goToClass(student);
            }

            //for (int i = 0; i < 10; i++)
            //{
            //    IComparable elemento = FabricaDeComparables.crearAleatorio(4);
            //    AlumnoAdapter alumnoAdapter = new AlumnoAdapter((IAlumno)elemento);
            //    teacher.goToClass(alumnoAdapter);
            //}

            teacher.teachingAClass();


        }
        public static void MainViejo()
        {
            IObservado p = new Profesor("Juan", 12345678, 5);
            AlumnoFavorito alumnoFav = new AlumnoFavorito("Juan", 12345678, 5, 1500);

            IColeccionable alumnos = new Conjunto();
            llenar(alumnos, 2);
            alumnos.agregar(alumnoFav);
            IIterador iterador = alumnos.iterador();
            while (!iterador.fin())
            {
                Alumno alumno = (Alumno)iterador.actual();
                Console.WriteLine(iterador.actual().ToString());
                p.agregarObservador(alumno);
                alumno.agregarObservador((AlumnoFavorito)alumnoFav);
                alumnoFav.agregarObservador((Profesor)p);
                iterador.siguiente();
            }
            //imprimirElementos(con);
            //informar(con);
            dictadoDeClases((Profesor)p);
            Console.WriteLine("El programa finalizó correctamente.\n");
            Console.ReadKey();

        }
    }
}
