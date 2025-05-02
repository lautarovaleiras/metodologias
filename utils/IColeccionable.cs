using metodologias.Iterator;
using metodologias.proyecto;

namespace metodologias
{
    public interface IColeccionable: IIterable
    {
        int cuantos();
        IComparable minimo();

        IComparable maximo();

        void agregar(IComparable c);
        bool contiene(IComparable c);
    }
}
