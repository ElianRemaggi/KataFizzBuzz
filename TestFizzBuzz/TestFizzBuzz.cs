using FizzBuzz;
using NUnit.Framework;
using System.Collections.Generic;

namespace TestFizzBuzz
{
    public class TestFizzBuzz
    {
        //Escribe un programa que produzca una lista finita de números, pero aplicando las siguientes normas:

        //** 1 - Devuelve Fizz si el número es divisible por 3.
        //** 2 - Devuelve Buzz si el número es divisible por 5.
        //** 3 - Devuelve FizzBuzz si el número es divisible por 3 y por 5

        [Test]
        [TestCase(9, ExpectedResult = "Fizz")]
        [TestCase(11, ExpectedResult = "11")]

        public string FizzBuzzCalcularTestFizz(int numero)
        {
            //Arrange
            FizzBuzz.FizzBuzz fizzBuzz = new FizzBuzz.FizzBuzz();
            string result;

            //Act
            result = fizzBuzz.CalcularNumero(numero);

            //Assert
            return result;
        }

        [Test]
        [TestCase(50, ExpectedResult = "Buzz")]
        [TestCase(2, ExpectedResult = "2")]

        public string FizzBuzzCalcularTestBuzz(int numero)
        {
            //Arrange
            FizzBuzz.FizzBuzz fizzBuzz = new FizzBuzz.FizzBuzz();
            string result;

            //Act
            result = fizzBuzz.CalcularNumero(numero);

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
            FizzBuzz.FizzBuzz fizzBuzz = new FizzBuzz.FizzBuzz();
            string result;

            //Act
            result = fizzBuzz.CalcularNumero(numero);

            //Assert
            return result;
        }

        [Test]
        public void FizzBuzzTestValidarLista()
        {
            //Arrange
            FizzBuzz.FizzBuzz fizzbuzz = new FizzBuzz.FizzBuzz();
            //Act
            Dictionary<int, string> dic = this.DataSource();
            //Assert
            foreach (var item in dic)
            {
                Assert.AreEqual(item.Value,fizzbuzz.CalcularNumero(item.Key));
            }            
        }

        public Dictionary<int, string> DataSource()
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
                {18, "Fizz" },
                {19, "19" },
                {20, "Buzz" },

            };

            return values;
        }

        //Alternativa a test completo usando TestCaseSource y metodo GenerarLista

        [Test]
        [TestCaseSource(nameof(testCaseSource))]
        public void FizzBuzzTestValidarListaAlt(int num, string numS)
        {
            //Arrange
            FizzBuzz.FizzBuzz fizzbuzz = new FizzBuzz.FizzBuzz();
            //Act
            string result = fizzbuzz.GenerarLista()[num - 1];
            //Assert
            Assert.AreEqual(numS, result);
        }

        static object[] testCaseSource =
        {
            new object[] {1, "1" },
            new object[] {2, "2" },
            new object[] {3, "Fizz" },
            new object[] {4, "4" },
            new object[] {5, "Buzz" },
            new object[] {6, "Fizz" },
            new object[] {7, "7" },
            new object[] {8, "8" },
            new object[] {9, "Fizz" },
            new object[] {10, "Buzz" },
            new object[] {11, "11" },
            new object[] {12, "Fizz" },
            new object[] {13, "13" },
            new object[] {14, "14" },
            new object[] {15, "FizzBuzz" },
            new object[] {16, "16" },
            new object[] {17, "17" },
            new object[] {18, "Fizz" },
            new object[] {19, "19" },
            new object[] {20, "Buzz" },
        };
    }                 
}           

   
 