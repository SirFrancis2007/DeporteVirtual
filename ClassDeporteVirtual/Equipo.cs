using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeporteVirtual
{
    public class Equipo
    {
        public List<Jugador> jugadores;
        public List<Sesiones> sesionesEntrenamiento;

        public double GetPotencia()
        {
            double[] potencias = new double[jugadores.Count];
            int potenciasPointer = 0;

            foreach (Jugador jugador in jugadores)
            {
                potencias[potenciasPointer] = jugador.Potencia;
                potenciasPointer++;
            }

            return potencias[0] + potencias[1];
        }

        public double GetPrecision()
        {
            double presicionTotal = 0;

            foreach (Jugador jugador in jugadores)
            {
                presicionTotal += jugador.GetPrecision();
            }

            return presicionTotal;
        }

        public double GetVision()
        {
            double visionTotal = 0;

            foreach (Jugador jugador in jugadores)
            {
                visionTotal += jugador.GetVisionGeneral();
            }

            return visionTotal;
        }

        public void Entrenar()
        {
            foreach(Jugador jugador in jugadores)
            {
                foreach(Sesiones sesion in sesionesEntrenamiento)
                {
                    sesion.AplicarA(jugador);
                }
            }
        }
    }
}
