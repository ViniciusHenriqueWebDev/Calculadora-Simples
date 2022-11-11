using CalculadoraAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalculadoraAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculadoraController : ControllerBase
    {
        [HttpGet("Somar/{valor1}/{valor2}")]
        public ActionResult<Calculadora> Somar(double valor1, double valor2)
        {
            var calc = new Calculadora(valor1, valor2);
            calc.somar();

            return Ok(calc);
        }

        [HttpGet("Subtrair/{valor1}/{valor2}")]
        public ActionResult<Calculadora> Subtrair(double valor1, double valor2)
        {
            var calc = new Calculadora(valor1, valor2);
            calc.subtrair();

            return Ok(calc);
        }

        [HttpGet("Multiplicar/{valor1}/{valor2}")]
        public ActionResult<Calculadora> Multiplicar(double valor1, double valor2)
        {
            var calc = new Calculadora(valor1, valor2);
            calc.multiplicar();

            return Ok(calc);
        }

        [HttpGet("Dividir/{valor1}/{valor2}")]
        public ActionResult<Calculadora> Dividir(double valor1, double valor2)
        {
            var calc = new Calculadora(valor1, valor2);
            calc.dividir();

            return Ok(calc);
        }
        


    }
}
