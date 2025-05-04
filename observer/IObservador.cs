using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodologias.observer
{
    public interface IObservador
    {

        void actualizar(IObservado o);
    }
}
