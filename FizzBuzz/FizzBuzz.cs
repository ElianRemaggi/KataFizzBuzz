using System;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public string GetFizzBuzz(int input)
        {
            return (input % 3 == 0 && input % 5 == 0) ? "FizzBuzz" :
                   (input % 5 == 0) ? "Buzz" :
                   (input % 3 == 0) ? "Fizz" :
                    input.ToString();
        }

        public List<string> GenerateNumberRange()
        {
            List<int> numbers = new List<int>();
            List<string> stringNumbers = new List<string>();

            numbers.AddRange(Enumerable.Range(1, 20).ToList());

            foreach (int number in numbers)
            {
                stringNumbers.Add(GetFizzBuzz(number));
            }

            return stringNumbers;
        }
    }
}
