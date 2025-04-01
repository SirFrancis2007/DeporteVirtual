using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeporteVirtual
{
    public class Defensor : Jugador
    {
        public double Quite { get; set; }

        public Defensor(double visionJuego, double visionGrupal, double potencia, double quite)
            => (VisionJuego, VisionGrupal, Potencia, Quite) = (visionJuego, visionGrupal, potencia, quite);

        public override void AplicarEntrenamientoFisico()
        {
            Potencia += 1;
            HabilidadPases += 0.5;
            Quite += 0.5;
        }

        public override void AplicarEntrenamientoLirico()
        {
            VisionJuego += 0.5;
            HabilidadPases += 1;
        }

        public override void AplicarEntrenamientoTactico()
        {
            VisionJuego += 0.5;
            VisionGrupal += 1;
        }

        public override double GetPrecision()
            => (3 * HabilidadPases) + Quite;

        public override double GetVisionGeneral()
            => VisionGrupal += VisionJuego;
    }
}
