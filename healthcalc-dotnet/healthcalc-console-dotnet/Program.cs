using healthcalc_pack_dotnet;
using healthcalc_pack_dotnet.Interfaces;

IIMC objeto = new IMC();

var imc = objeto.CalcularIMC(125, 1.70);
var resultado = objeto.RetornarClassificacaoIMC(imc);

Console.WriteLine("Seu resultado é: " + resultado);
