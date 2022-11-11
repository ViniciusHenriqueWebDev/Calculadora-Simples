using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraAPI.Models
{
    public class Calculadora
    {
        public double Valor1 { get; set; }
        public double Valor2 { get; set; }

        public double HorasCurso { get; set; }

        public double Resultado { get; set; }

        public Calculadora()
        {

        }
        public Calculadora(double valor1, double valor2, double resultado)
        {
            Valor1 = valor1;
            Valor2 = valor2;
            Resultado = resultado;
        }

        public Calculadora(double valor1, double valor2)
        {
            Valor1 = valor1;
            Valor2 = valor2;
        }

        public void somar()
        {
            Resultado = Valor1 + Valor2; 
        }
        public void subtrair()
        {
            Resultado = Valor1 - Valor2;
        }
        public void dividir()
        {
            Resultado = Valor1 / Valor2;
        }
        public void multiplicar()
        {
            Resultado = Valor1 * Valor2;
        }

    }
}
