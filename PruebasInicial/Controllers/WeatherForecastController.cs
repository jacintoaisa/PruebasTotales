using Microsoft.AspNetCore.Mvc;
using PruebasInicial.Services;
using System.Runtime.CompilerServices;

namespace PruebasInicial.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    { 
        private readonly ICalculadora MiCalculadora;
        private readonly IConcatenador Concatenador;

        public WeatherForecastController(ICalculadora calculadora, IConcatenador concatenador)
        {
            this.MiCalculadora = calculadora;
            this.Concatenador = concatenador;
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
        [Route("Concatena/{cadena1:string}/{cadena2:string}")]
        public string Concatena(string cadena1, string cadena2)
        {
            return this.Concatenador.contatena(cadena1,cadena2);
        }
        [HttpGet]
        [Route("Concatena/{cadena1:string}/{cadena2:string}")]
        public int RestaCadena(string cadena1, string cadena2)
        {
            return this.Concatenador.diferenciaContaje(cadena1, cadena2);
        }

    }
}
