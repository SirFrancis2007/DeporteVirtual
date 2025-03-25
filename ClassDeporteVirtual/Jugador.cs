namespace DeporteVirtual
{
    public abstract class Jugador
    {
        public double visionJuego  { get; set; }
        public double VisionGrupal { get; set; }
        public double Potencia { get; set; }
        public double HabilidadPases { get; set; }

        public abstract double GetPresicion();
        public abstract double GetVisionGeneral();
        public abstract double AplicarEntrenamientoFisico();


    }
}
