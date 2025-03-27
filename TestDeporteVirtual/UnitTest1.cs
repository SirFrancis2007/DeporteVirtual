using DeporteVirtual;

namespace TestDeporteVirtual
{
    public class UnitTest1
    {
        Fixture fixture;
        public UnitTest1() => fixture = new();
        
        [Fact]
        public void CrearJugadoresOK()
        {
            Assert.NotNull(fixture.atacante1);
            Assert.NotNull(fixture.defensa1);
        }

        [Fact]
        public void GetEntrenamientoFisico()
        {
            var potenciaInicial = fixture.atacante1.Potencia;
            fixture.atacante1.AplicarEntrenamientoFisico();
            Assert.True(fixture.atacante1.Potencia > potenciaInicial);
        }

        //[Fact]
        // revisar este!
        /*public void GetEntrenamientoLiricoDef()
        {
            var visionJuegoInicial = fixture.defensa1.VisionJuego;
            fixture.defensa1.AplicarEntrenamientoLirico();
            Assert.True(fixture.defensa1.VisionJuego > visionJuegoInicial);
        }*/

        [Fact]
        public void GetPresicionAtacan()
        {
            var precision = fixture.atacante1.GetPresicion();
            Assert.True(precision >= 0);
        }

        [Fact]
        public void GetVisionGeneralDef()
        {
            var vision = fixture.defensa1.GetVisionGeneral();
            Assert.True(vision >= 0);
        }
    }
}