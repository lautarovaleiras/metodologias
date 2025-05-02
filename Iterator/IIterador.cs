using System.Collections.Generic;
using System.Linq;
using System.Text;
using metodologias.proyecto;
namespace metodologias.Iterator
{
    public interface IIterador
    {
        void primero();
        void siguiente();
        bool fin();
        IComparable actual();
    }
}
