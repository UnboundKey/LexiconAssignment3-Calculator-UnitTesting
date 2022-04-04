using System;
using UnboundKey.Core;

namespace LexiconAssignment3_Calculator_UnitTesting
{
    public class Calculator
    {
        private static string parsingErrorMessage = "One or more Numbers cannot be parsed, using 0 instead";
        
        public static double Addition(double num1, double num2)
        {
            return num1 + num2;
        }

        public static double Addition(string[] numbers)
        {
            double total = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                total += numbers[i].ParseDouble(parsingErrorMessage);
            }

            return total;
        }

        public static double Subtraction(double num1, double num2)
        {
            return num1 - num2;
        }

        public static double Subtraction(string[] numbers)
        {
            // Setting first number in the array as the base to subtract from
            double total = numbers[0].ParseDouble(0,parsingErrorMessage);
            for (int i = 1; i < numbers.Length; i++)
            {
                total -= numbers[i].ParseDouble(0);
            }

            return total;
        }

        public static double Multiplication(double firstNum, double secondNum)
        {
            return firstNum * secondNum;
        }

        public static double Division(double firstNum, double secondNum)
        {
            if (firstNum == 0 || secondNum == 0)
            {
                Console.WriteLine("Cannot divide by zero (0) Result will be zero (0)");
                return 0;
            }

            return firstNum / secondNum;
        }
    }
}