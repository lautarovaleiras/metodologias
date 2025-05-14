using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodologias.template
{
    abstract class JuegoDeCartas
    {
        public abstract void mezclarMazo();
        public abstract void repartirCartas();
        public abstract void jugarMano();
        public abstract void mostrarGanador();
    }
}
