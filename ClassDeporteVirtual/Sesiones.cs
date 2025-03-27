namespace DeporteVirtual
{
    public abstract class Sesiones
    {
        public string nombre;
        public abstract void AplicarA(Jugador jugador);
    }

    public class SesionTactica
    {
        public void AplicarA(Jugador jugador)
            => jugador.AplicarEntrenamientoTactico();
    }

    public class SesionLirica
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
