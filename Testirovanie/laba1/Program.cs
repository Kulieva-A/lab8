using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Testirovanie.Lab1
{
    public static class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите через запятую целые числа и нажмите Enter");
            string input = Console.ReadLine();
            BubbleSort(input);

            Console.WriteLine('\n' + "Введите строку");
            string word = Console.ReadLine();
            if (IsPalindrom(word)) Console.WriteLine("Строка является палиндромом");
            else Console.WriteLine("Строка не является палиндромом");

            Console.WriteLine('\n' + "Введите число вычисления факториала");
            string number = Console.ReadLine();
            Factorial(number);

            Console.WriteLine('\n' + "Введите значение позиции числа Фибоначчи");
            string position = Console.ReadLine();
            Fibonacci(position);

            Console.WriteLine("Введите число для возведения в степень");
            string baseNumber = Console.ReadLine();
            Console.WriteLine("Введите степень");
            string exponent = Console.ReadLine();
            try
            {
                double result = Power(baseNumber, exponent);
                Console.WriteLine($"{baseNumber} в степени {exponent} равно {result}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Ошибка. " + ex.Message);
            }

            Console.WriteLine("Введите число");
            string u = Console.ReadLine();
            if (IsPrime(u)) Console.WriteLine("Число является простым");
            else Console.WriteLine("Введено не простое число");
        }

        public static int[] BubbleSort(string input)
        {
            try
            {
                string[] nums = input.Split(new char[] { ',' });
                int[] intArray = new int[nums.Length];
                for (int i = 0; i < nums.Length; i++)
                {
                    intArray[i] = int.Parse(nums[i]);
                }

                for (int i = 0; i < intArray.Length; i++)
                    for (int j = 0; j < intArray.Length - i - 1; j++)
                    {
                        if (intArray[j] > intArray[j + 1])
                        {
                            int temp = intArray[j];
                            intArray[j] = intArray[j + 1];
                            intArray[j + 1] = temp;
                        }
                    }

                Console.WriteLine($"Отсортированный массив: ");
                for (int i = 0; i < nums.Length; i++)
                {
                    Console.Write(intArray[i] + ",");
                }
                return intArray;

            }
            catch
            {
                Console.WriteLine("Неверный формат ввода. Пожалуйста, вводите только целые числа разделенные запятой.");
                return new int[0];
            }

        }

        public static bool IsPalindrom(string word)
        {
            if (string.IsNullOrEmpty(word))
            {
                Console.WriteLine("Данные не были введены");
                return false;
            }
            else
            {
                var left = 0;
                var right = word.Length - 1;

                while (left < right)
                {
                    if (word[left] != word[right]) return false;
                    left++;
                    right--;
                }
                return true;
            }
        }

        public static int Factorial(string number)
        {
            if (int.TryParse(number, out int numeric) && numeric > 0)
            {
                int n = int.Parse(number);
                int result = 1;
                for (int i = 1; i <= n; i++)
                {
                    result *= i;
                }
                Console.WriteLine($"Факториал {number} равен {result}");
                return result;
            }
            else
            {
                Console.WriteLine("Вы ввелии неверные данные.");
                return -1;
            }
        }

        public static int Fibonacci(string position)
        {
            if (int.TryParse(position, out int numericValue) && numericValue > 0)
            {
                int p = int.Parse(position);
                int fib1 = 1;
                int fib2 = 1;
                int fibonacci = 0;

                if (p == 1)
                {
                    Console.WriteLine($"Число Фибоначчи на позиции {position} равно 0");
                    return 0;
                }
                if (p == 2 || p == 3)
                {
                    Console.WriteLine($"Число Фибоначчи на позиции {position} равно 1");
                    return 1;
                }
                else
                {
                    for (int i = 3; i < p; i++)
                    {
                        fibonacci = fib1 + fib2;
                        fib1 = fib2;
                        fib2 = fibonacci;
                    }
                    Console.WriteLine($"Число Фибоначчи на позиции {position} равно {fibonacci}");
                    return fibonacci;
                }
            }
            else
            {
                Console.WriteLine("Вы ввелии неверные данные позиции числа.");
                return -1;
            }

        }

        public static double Power(string baseNumber, string exponent)
        {
            double mat;
            if (double.TryParse(baseNumber, out mat) && double.TryParse(exponent, out mat))
            {
                double a = double.Parse(baseNumber);
                double b = double.Parse(exponent);
                return Math.Pow(a, b);

            }
            else
            {
                throw new ArgumentException("Вы ввели неверные данные.");
            }
        }

        public static bool IsPrime(string u)
        {
            if (int.TryParse(u, out int c))
            {
                int num = int.Parse(u);
                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                        return false;
                }
                return true;

            }
            else
            {
                Console.WriteLine("Вы ввелии неверные данные.");
                return false;
            }
        }

    }

}