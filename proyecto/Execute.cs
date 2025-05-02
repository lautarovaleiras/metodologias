using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using metodologias.utils;
using metodologias.Iterator;
using metodologias.Strategy;
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

        public static void informar(IColeccionable c)
        {
            Console.WriteLine(c.cuantos());
            Console.WriteLine(c.maximo());
            Console.WriteLine(c.minimo());
            //int numeroLeido = int.Parse(Console.ReadLine());
            //IComparable comp = new Numero(numeroLeido);

            Console.WriteLine("Ingrese nombre, dni, legajo y promedio para ver si está en la colección:");

            string nombre = Console.ReadLine();
            int dni;
            while (!int.TryParse(Console.ReadLine(), out dni))
            {
                Console.WriteLine("DNI inválido. Ingrese un número válido:");
            }

            int legajo;
            while (!int.TryParse(Console.ReadLine(), out legajo))
            {
                Console.WriteLine("Legajo inválido. Ingrese un número válido:");
            }

            double promedio;
            while (!double.TryParse(Console.ReadLine(), out promedio))
            {
                Console.WriteLine("Promedio inválido. Ingrese un número válido:");
            }

            IComparable elemento = new Alumno(nombre, dni, promedio, legajo);


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
            IColeccionable con = new Conjunto();
            llenarAlumnos(con);
            imprimirElementos(con);
            informar(con);
            //cambiarEstrategia(con, new DniStrategy());
            //informar(con);


            //ColeccionMultiple cm = new ColeccionMultiple(pila, cola);

            //informar(cm);
            Console.WriteLine("El programa finalizó correctamente.\n");
            Console.ReadKey();

        }
    }
}
