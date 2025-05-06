using metodologias.adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodologias.command
{
    public interface IOrdenEnAula2
    {
        void ejecutar(IAlumno c);
    }
}
