using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Services
{
    public class CalculadoraImp
    {
        private List<string> Listhistorico;

        public CalculadoraImp()
        {
            Listhistorico = new List<string>();
        }
        public int Somar (int num1, int num2 ) {
            Listhistorico.Add($"{num1} + {num2} = {num1 + num2}");
            return num1 + num2;
        }
        public int Subtrair (int num1, int num2 ) {
            Listhistorico.Add($"{num1} - {num2} = {num1 - num2}");
            return num1 - num2;
        }

        public int Multiplicar (int num1, int num2 ) {
            Listhistorico.Add($"{num1} * {num2} = {num1 * num2}");
            return num1 * num2;
        }

        public int Dividir (int num1, int num2 ) {
            Listhistorico.Add($"{num1} / {num2} = {num1 / num2}");
            return num1 / num2;
        }

        public List<string> historico() {
            Listhistorico.RemoveRange(3, Listhistorico.Count - 3);
            return Listhistorico;
        }
    }
}