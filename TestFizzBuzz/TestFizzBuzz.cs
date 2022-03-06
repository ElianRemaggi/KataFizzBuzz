using BibliotecaDeClase;
using NUnit.Framework;
using System.Collections.Generic;

namespace TestFizzBuzz
{
    public class Tests
    {
        //Escribe un programa que produzca una lista finita de números, pero aplicando las siguientes normas:

        //** 1 - Devuelve Fizz si el número es divisible por 3.
        //** 2 - Devuelve Buzz si el número es divisible por 5.
        //* 3 - Devuelve FizzBuzz si el número es divisible por 3 y por 5

        [Test]
        [TestCase(9, ExpectedResult = "Fizz")]
        [TestCase(11, ExpectedResult = "11")]

        public string FizzBuzzCalcularTestFizz(int numero)
        {

            //Arrange
            FizzBuzz fizzBuzz = new FizzBuzz();
            string result;

            //Act
            result = fizzBuzz.Calcular(numero);

            //Assert
            return result;
        }

        [Test]
        [TestCase(50, ExpectedResult = "Buzz")]
        [TestCase(2, ExpectedResult = "2")]

        public string FizzBuzzCalcularTestBuzz(int numero)
        {

            //Arrange
            FizzBuzz fizzBuzz = new FizzBuzz();
            string result;

            //Act
            result = fizzBuzz.Calcular(numero);

            //Assert
            return result;
        }

        [Test]
        [TestCase(60, ExpectedResult = "FizzBuzz")]
        [TestCase(15, ExpectedResult = "FizzBuzz")]
        [TestCase(90, ExpectedResult = "FizzBuzz")]
        [TestCase(2, ExpectedResult = "2")]

        public string FizzBuzzCalcularTestFizzBuzz(int numero)
        {

            //Arrange
            FizzBuzz fizzBuzz = new FizzBuzz();
            string result;

            //Act
            result = fizzBuzz.Calcular(numero);

            //Assert
            return result;
        }

        public Dictionary<int, string> dataSource()
        {
            Dictionary<int, string> values = new Dictionary<int, string>
            {
                {1, "1" },
                {2, "2" },
                {3, "Fizz" },
                {4, "4" },
                {5, "Buzz" },
                {6, "Fizz" },
                {7, "7" },
                {8, "8" },
                {9, "Fizz" },
                {10, "Buzz" },
                {11, "11" },
                {12, "Fizz" },
                {13, "13" },
                {14, "14" },
                {15, "FizzBuzz" },
                {16, "16" },
                {17, "17" },
            };

            return values;
        }

        [Test]
        public void testCompleto()
        {
            //Arrange
            FizzBuzz fizzbuzz = new FizzBuzz();
            //Art
            Dictionary<int, string> dic = this.dataSource();
            //Assert
            foreach (var item in dic)
            {
                Assert.AreEqual(item.Value,fizzbuzz.Calcular(item.Key));
            }            
        }
    }
}
