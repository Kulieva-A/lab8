using System;
using System.Linq;
using NUnit.Framework;

namespace Testirovanie.Lab1
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void BubbleSort_True()
        {
            string input = "3,2,1,5,4";
            int[] expected = new int[] { 1, 2, 3, 4, 5 };

            int[] result = Program.BubbleSort(input);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void BubbleSort_Error()
        {
            string input = "5,f,c,t";
            int[] expected = new int[0];

            int[] result = Program.BubbleSort(input);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void IsPalindrom_True()
        {
            string input = "radar";
            bool expected = true;

            bool result = Program.IsPalindrom(input);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void IsPalindrom_False()
        {
            string input = "";
            bool expected = false;

            bool result = Program.IsPalindrom(input);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Factorial_Correct()
        {
            string input = "5";
            int expected = 120;

            int result = Program.Factorial(input);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Factorial_MinusOne()
        {
            string input = "-5";
            int expected = -1;

            int result = Program.Factorial(input);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Fibonacci_Zero()
        {
            string input = "1";
            int expected = 0;

            int result = Program.Fibonacci(input);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Fibonacci_MinusOne()
        {
            string input = "abc";
            int expected = -1;

            int result = Program.Fibonacci(input);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Power_Error()
        {
            string baseNumber = "abc";
            string exponent = "def";

            Assert.Throws<ArgumentException>(() => Program.Power(baseNumber, exponent));
        }

        [Test]
        public void Power_ReturnsOne()
        {
            string baseNumber = "5";
            string exponent = "0";
            double expected = 1;

            double result = Program.Power(baseNumber, exponent);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void IsPrime_False()
        {
            string input = "abc";

            bool result = Program.IsPrime(input);

            Assert.IsFalse(result);
        }

        [Test]
        public void IsPrime_PrimeNumber_ReturnsTrue()
        {
            string input = "7";
            bool expected = true;

            bool result = Program.IsPrime(input);

            Assert.AreEqual(expected, result);
        }

    }
}