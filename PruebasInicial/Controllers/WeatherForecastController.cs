using Microsoft.AspNetCore.Mvc;
using PruebasInicial.Services;
using System.Runtime.CompilerServices;
using System.Text.Encodings.Web;

namespace PruebasInicial.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ICalculadora MiCalculadora;
        private readonly IConcatenador Concatenador;
        private readonly IMultiplosyDivisores multiplosyDivisores;
        public WeatherForecastController(ICalculadora calculadora, IConcatenador concatenador, IMultiplosyDivisores multiplosyDivisores)
        {
            this.MiCalculadora = calculadora;
            this.Concatenador = concatenador;
            this.multiplosyDivisores = multiplosyDivisores;
        }
        [HttpGet]
        [Route("GetSuma/{numero1:int}/{numero2:int}")]
        public double GetSuma(int numero1, int numero2)
        {
            return MiCalculadora.Suma(numero1, numero2);
        }
        [HttpGet]
        [Route("GetResta/{numero1:int}/{numero2:int}")]
        public double GetResta(int numero1, int numero2)
        {
            return MiCalculadora.Resta(numero1, numero2);
        }
        [HttpGet]
        [Route("GetMultiplica/{numero1:int}/{numero2:int}")]
        public double GetMultiplica(int numero1, int numero2)
        {
            return MiCalculadora.Multiplica(numero1, numero2);
        }
        [HttpGet]
        [Route("GetDivide/{numero1:int}/{numero2:int}")]
        public double GetDivide(int numero1, int numero2)
        {
            return MiCalculadora.Divide(numero1, numero2);
        }

        [HttpGet]
        [Route("Concatena/{cadena1}/{cadena2}")]
        public string Concatena(string cadena1, string cadena2)
        {
            return HtmlEncoder.Default.Encode(this.Concatenador.contatena(cadena1, cadena2));
        }
        [HttpGet]
        [Route("RestaCadena/{cadena1}/{cadena2}")]
        public int RestaCadena(string cadena1, string cadena2)
        {
            return this.Concatenador.diferenciaContaje(cadena1, cadena2);
        }
        [HttpGet]
        [Route("MaximoComunDivisor/{valor1:int}/{valor2:int}")]
        public int MaximoComunDivisor(int valor1, int valor2)
        {
            return this.multiplosyDivisores.MaximoComunDivisor(valor1, valor2);
        }


        [HttpGet]
        [Route("MinimoComunMultiplo/{valor1:int}/{valor2:int}")]
        public int MinimoComunMultiplo(int valor1, int valor2)
        {
            return this.multiplosyDivisores.MinimoComunMultiplo(valor1, valor2);
        }
    }
}
