using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeporteVirtual
{
    internal abstract class Sesion
    {
        public string nombre;

        public abstract void AplicarA(Jugador jugador);
    }
}
