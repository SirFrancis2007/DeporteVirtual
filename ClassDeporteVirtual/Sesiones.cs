namespace DeporteVirtual
{
    internal abstract class Sesiones
    {
        public string nombre;
        public abstract void AplicarA(Jugador jugador);
    }

    internal class SesionTactica
    {
        public void AplicarA(Jugador jugador)
            => jugador.AplicarEntrenamientoTactico();
    }

    internal class SesionLirica
    {
        public void AplicarA(Jugador jugador)
            => jugador.AplicarEntrenamientoLirico();
    }

    internal class SesionFisica
    {
        public void AplicarA(Jugador jugador)
            => jugador.AplicarEntrenamientoFisico();
    }
}
