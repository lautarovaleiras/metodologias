using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodologias.factory
{
    public class GenereadorDeDatosAleatorios
    {
        public GenereadorDeDatosAleatorios()
        {
        
        }

        public int numeroAleatoreo(int max)
        {
            var guid = Guid.NewGuid();
            var justNumbers = new String(guid.ToString().Where(Char.IsDigit).ToArray());
            var seed = int.Parse(justNumbers.Substring(0, 4));
            Random random = new Random(seed);

            return random.Next(1, max);
        }

        public double doubleAleatorio()
        {
            var guid = Guid.NewGuid();
            var justNumbers = new String(guid.ToString().Where(Char.IsDigit).ToArray());
            var seed = int.Parse(justNumbers.Substring(0, 4));
            Random random = new Random(seed);

            return Math.Round(1 + (random.NextDouble() * 9), 2);
        }

        public string stringAleatoreo(int cant)
        {
            var guid = Guid.NewGuid();
            var justNumbers = new String(guid.ToString().Where(Char.IsDigit).ToArray());
            var seed = int.Parse(justNumbers.Substring(0, 4));
            Random random = new Random(seed);

            const string alfabeto = "abcdefghijklmnopqrstuvwxyz";
            StringBuilder token = new StringBuilder();
            for (int i = 0; i < cant; i++)
            {
                int indice = random.Next(alfabeto.Length);
                token.Append(alfabeto[indice]);
            }
            return token.ToString();
        }
    }
}
