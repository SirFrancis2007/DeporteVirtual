using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeporteVirtual
{
    internal class Defensor : Jugador
    {
        public double Quite { get; set; }

        public override double AplicarEntrenamientoFisico()
        {
            throw new NotImplementedException();
        }

        public override double AplicarEntrenamientoLirico()
        {
            throw new NotImplementedException();
        }

        public override double AplicarEntrenamientoTactico()
        {
            throw new NotImplementedException();
        }

        public override double GetPresicion() => Convert.ToDouble((3 * HabilidadPases + Quite));

        public override double GetVisionGeneral() => VisionCompanero += visionJuego;
    }
}
