using healthcalc_pack_dotnet;
using healthcalc_pack_dotnet.Enums;
using healthcalc_pack_dotnet.Interfaces;
using healthcalc_pack_dotnet.Models;

namespace healthcalc_teste_dotnet.Pack
{
    public class MacronutrientesTest
    {
        [Fact]
        public void CalculaIMC_QuandoPesoEAlturaValidos_EntaoRetornaIndice()
        {
            //Arrange
            IMacronutrientes macros = new Macronutrientes();
            double Peso = 85;
            var ObjetivoFisico = ObjetivoFisicoEnum.Cutting;
            var MacrosEsperados = new ResultadoMacronutrientesModel()
            {
                Proteinas = 170.0,
                Gorduras = 85.0,
                Carboidratos = 170.0,
            };


            //Act
            var resultadoMacros = macros.CalcularMacronutrientes(Peso, ObjetivoFisico);

            //Asserts
            Assert.Equivalent(MacrosEsperados, resultadoMacros);
        }
    }
}