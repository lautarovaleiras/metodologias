using metodologias.proyecto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodologias.template
{
    class Truco : JuegoDeCartas
    {
        Alumno jugador1;
        Alumno jugador2;

        Alumno ganador = null;

        // Diccionario de para almacenar los puntos de cada jugador
        Dictionary<Alumno, int> puntos = new Dictionary<Alumno, int>();

        public Truco(Alumno jugador1, Alumno jugador2)
        {
            Console.WriteLine("Creando el juego de truco...");
            this.jugador1 = jugador1;
            this.jugador2 = jugador2;
        }

        public override void jugarMano()
        {
            Console.WriteLine("Jugando una mano de truco...");
            Console.WriteLine("El jugador " + jugador1.getNombre() + " toma cartas");
            Console.WriteLine("El jugador " + jugador2.getNombre() + " toma cartas");

            Random random = new Random();
            int resultado = random.Next(1, 3); // Simula el resultado de la mano
            if (resultado == 1)
            {
                puntos[jugador1] = puntos.ContainsKey(jugador1) ? puntos[jugador1] + 1 : 1;
            }
            else
            {
                puntos[jugador2] = puntos.ContainsKey(jugador2) ? puntos[jugador2] + 1 : 1;
            }
            Console.WriteLine("El jugador " + jugador1.getNombre() + " descarta las  cartas");
            Console.WriteLine("El jugador " + jugador2.getNombre() + " descarta las  cartas");
        }

        public override void mezclarMazo()
        {
            Console.WriteLine("Mezclando el mazo de cartas del truco...");
        }

        public override void mostrarGanador()
        {
            if (ganador != null)
            {
                Console.WriteLine("El ganador es: " + ganador.ToString());
            }
            else
            {
                Console.WriteLine("No hay ganador.");
            }
        }

        public override void repartirCartas()
        {
            Console.WriteLine("Repartiendo cartas del truco...");
        }

        // Si un jugador llega a 15 puntos, se considera ganador
        public bool checkGanador()
        {
            if (puntos.ContainsKey(jugador1) && puntos[jugador1] >= 15)
            {
                ganador = jugador1;
                return true;
            }
            else if (puntos.ContainsKey(jugador2) && puntos[jugador2] >= 15)
            {
                ganador = jugador2;
                return true;
            }
            return false;
        }
    }
}
