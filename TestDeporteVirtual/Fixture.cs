using ClassDeporteVirtual;
using DeporteVirtual;

namespace TestDeporteVirtual
{
    internal class Fixture
    {
        private Atacante _atacante1;
        public Jugador atacante1 => _atacante1;

        private Defensor _defensa1;
        public Jugador defensa1 => _defensa1;

        private Equipo _equipo;
        public Equipo equipo => _equipo;
        public Fixture()
        {
            _atacante1 = new(0, 0, 0, 0);
            _defensa1 = new(0, 0, 0, 0);

            _equipo = new Equipo { jugadores = new List<Jugador> { _atacante1, _defensa1 } };
        }
    }
}
