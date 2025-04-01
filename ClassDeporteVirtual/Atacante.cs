using DeporteVirtual;

namespace ClassDeporteVirtual
{
    public class Atacante : Jugador
    {
        public double Anotacion { get; set; }

        public Atacante(double visionJuego, double visionGrupal, double potencia, double anotacion)
         => (VisionJuego, VisionGrupal, Potencia, Anotacion) = (visionJuego, visionGrupal, potencia, anotacion);

        public override void AplicarEntrenamientoFisico()
        {
            Potencia += 1;
            HabilidadPases += 0.5;
        }

        public override void AplicarEntrenamientoLirico()
        {
            HabilidadPases += 1;
            Anotacion += 0.5;
        }

        public override void AplicarEntrenamientoTactico()
        {
            HabilidadPases += 0.5;
            VisionJuego += 0.5;
            VisionGrupal += 0.5;
        }

        public override double GetPrecision()
            => 3 * HabilidadPases + Anotacion;

        public override double GetVisionGeneral()
            => VisionJuego += HabilidadPases;
    }
}
