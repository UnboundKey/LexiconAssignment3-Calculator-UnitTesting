using System;
using UnboundKey.Core;

namespace LexiconAssignment3_Calculator_UnitTesting
{
    class Program
    {
        private static readonly string[] programs = { "Exit", "Addition", "Subtraction", "Division", "Multiplication" };

        static void Main()
        {
            Console.WriteLine("Welcome to Calculator!");
            while (true)
            {
                Console.WriteLine("Write a number to pick a program");
                for (int i = 0; i < programs.Length; i++)
                {
                    Console.WriteLine(i + ") " + programs[i]);
                }
                string conInput = Console.ReadLine();
                // makes sure input is a number, if not it defaults to one past the max programs triggering the default response;
                int conParsedInput = conInput.ParseInt(programs.Length);

                switch (conParsedInput)
                {
                    case 0:
                        Environment.Exit(0);
                        break;
                    case 1:
                        DoAddition();
                        break;
                    case 2:
                        DoSubtraction();
                        break;
                    case 3:
                        DoDivision();
                        break;
                    case 4:
                        DoMultiplication();
                        break;
                }
            }
        }

        private static void DoAddition()
        {
            Console.WriteLine("Welcome to addition");
            Console.WriteLine("You can either enter one number [num1], or multiple [num1,num2,num3]");

            string firstInput = Helper.ConWriteRead("Please enter a number to add:");
            string secondInput;
            double sum;
            
            if (firstInput.Contains(','))
            {
                sum = Calculator.Addition(firstInput.ToStringArray());
            }
            else
            {
                secondInput = Helper.ConWriteRead("Please enter another number:");
                sum = Calculator.Addition(firstInput.ParseDouble(), secondInput.ParseDouble());
            }

            Console.Write("The Sum of these numbers are: ");
            Console.WriteLine(sum);
        }

       
        private static void DoSubtraction()
        {
            
            Console.WriteLine("Welcome to subtraction");
            Console.WriteLine("You can either enter one number [num1], or multiple [num1,num2,num3]");
            string firstInput = Helper.ConWriteRead("Please enter a number:");
            string secondInput;
            double sum;
            
            if (firstInput.Contains(','))
            {
                sum = Calculator.Subtraction(firstInput.ToStringArray());
            }
            else
            {
                secondInput = Helper.ConWriteRead("Please enter another number:");
                sum = Calculator.Subtraction(firstInput.ParseDouble(), secondInput.ParseDouble());
            }
            
            Console.Write("The Sum of these numbers are: ");
            Console.WriteLine(sum);
        }

        private static void DoDivision()
        {
            Console.WriteLine("Welcome to division");

            double sum = 0;
            double firstNum = Helper.ConWriteRead("Please enter a number:").ParseDouble();
            double secondNum = Helper.ConWriteRead("Please enter what to divide by:").ParseDouble();

            sum = Calculator.Division(firstNum, secondNum);
            
            Console.Write("The Sum of these numbers are: ");
            Console.WriteLine(sum);

        }
        
        private static void DoMultiplication()
        {
            Console.WriteLine("Welcome to multiply");
            double firstNum = Helper.ConWriteRead("Please enter a number:").ParseDouble();
            double secondNum = Helper.ConWriteRead("Please enter what to multiply by:").ParseDouble();

            Console.Write("The Result is: ");
            Console.WriteLine(Calculator.Multiplication(firstNum,secondNum));
        }
    }
}
