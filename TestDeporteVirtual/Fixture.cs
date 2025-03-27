using ClassDeporteVirtual;
using DeporteVirtual;

namespace TestDeporteVirtual
{
    internal class Fixture
    {
        public Jugador atacante1 => _atacante1;
        private Atacante _atacante1;

        public Jugador defensa1 => _defensa1;
        private Atacante _defensa1;
        public Fixture()
        {
            _atacante1 = new(0, 0, 0, 0);
            _defensa1 = new(0, 0, 0, 0);
            var equipo = new Equipo { jugadores = new List<Jugador> { _atacante1, _defensa1 } };
        }
    }
}
