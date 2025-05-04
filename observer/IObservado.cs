using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodologias.observer
{
    public interface IObservado
    {
        void agregarObservador(IObservador o);
        void quitarObservador(IObservador o);
        void notificar();
        //void setEstado(string estado);
        //string getEstado();
    }
}
