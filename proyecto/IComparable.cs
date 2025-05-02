using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace metodologias.proyecto
{
   public interface IComparable
    {
        bool sosIgual(IComparable c);
        bool sosMenor(IComparable c);
        bool sosMayor(IComparable c);
    }
}
