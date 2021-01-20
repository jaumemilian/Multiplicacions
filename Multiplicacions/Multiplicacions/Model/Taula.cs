using System.Collections.Generic;

namespace Multiplicacions.Model
{
    public class Taula
    {
        public Taula(int nombre)
        {
            Nombre = nombre;

            Linees = new Dictionary<string, int>();

            for (var i = 1; i <= 10; i++)
            {
                Linees.Add(nombre + " x " + i, nombre * i);
            }
        }

        public int Nombre { get; set; }

        public Dictionary<string, int> Linees { get; set; }
    }
}