using System;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public string CalcularNumero(int numero)
        {
            return (numero % 3 == 0 && numero % 5 == 0) ? "FizzBuzz" : 
                   (numero % 5 == 0) ? "Buzz" :
                   (numero % 3 == 0) ? "Fizz" : 
                    numero.ToString();
        }

        public List<string> GenerarLista()
        {
            List<int> numeros = new List<int>();
            List<string> numerosString = new List<string>();

            numeros.AddRange(Enumerable.Range(1, 20).ToList());

            foreach (int numero in numeros)
            {
                numerosString.Add(CalcularNumero(numero));
            }

            return numerosString;
        }
    }
}
