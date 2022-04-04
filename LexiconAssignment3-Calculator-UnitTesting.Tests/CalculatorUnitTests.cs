using System;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Utilities;
using Xunit;
using UnboundKey.Core;

namespace LexiconAssignment3_Calculator_UnitTesting.Tests
{
    public class CalculatorUnitTests
    {
        [Fact]
        public void Addition_Double_PossitiveNumbers()
        {
            //setup
            double num1 = 2;
            double num2 = 2;

            double result = Calculator.Addition(num1, num2);
            
            Assert.Equal(4, result);
        }
        
        [Fact]
        public void Addition_Double_NegativeNumbers()
        {
            //setup
            double num1 = -2;
            double num2 = 2;

            double result = Calculator.Addition(num1, num2);
            
            Assert.Equal(0, result);
        }
        
        [Fact]
        public void Addition_StringArray_PositiveNumbers()
        {
            //Set Up
            string[] numbers = {"1", "1", "0", "6"};
            
            //Test
            double result = Calculator.Addition(numbers);
            
            //Result
            Assert.Equal(8, result);
        }
        
        [Fact]
        public void Addition_StringArray_EmptyString()
        {
            //Set Up
            string[] numbers = {"1", "", "6"};
            
            //Test
            double result = Calculator.Addition(numbers);
            
            //Result
            Assert.Equal(7, result);
        }
        
        //Subtraction Tests
        
        [Fact]
        public void Subtraction_Double_PossitiveNumbers()
        {
            //setup
            double num1 = 2;
            double num2 = 2;

            double result = Calculator.Subtraction(num1, num2);
            
            Assert.Equal(0, result);
        }
        
        [Fact]
        public void Subtraction_Double_NegativeNumbers()
        {
            //setup
            double num1 = -2;
            double num2 = 2;

            double result = Calculator.Subtraction(num1, num2);
            
            Assert.Equal(-4, result);
        }
        
        [Fact]
        public void Subtraction_StringArray_PositiveNumbers()
        {
            //Set Up
            string[] numbers = {"10", "1", "0", "6"};
            
            //Test
            double result = Calculator.Subtraction(numbers);
            
            //Result
            Assert.Equal(3, result);
        }
        
        [Fact]
        public void Subtraction_StringArray_EmptyString()
        {
            //Set Up
            string[] numbers = {"1", "", "6"};
            
            //Test
            double result = Calculator.Subtraction(numbers);
            
            //Result
            Assert.Equal(-5, result);
        }

        [Fact]
        public void Division_Double_PositiveNumbers()
        {
            //Set up
            double num1 = 5;
            double num2 = 2;
            
            // Test
            double result = Calculator.Division(num1,num2);
            
            //Result
            Assert.Equal(2.5,result);
        }
        
        [Fact]
        public void Division_Double_NegativeNumbers()
        {
            //Set up
            double num1 = -10;
            double num2 = 2;
            
            // Test
            double result = Calculator.Division(num1,num2);
            
            //Result
            Assert.Equal(-5,result);
        }
        
        [Fact]
        public void Division_by_Zero()
        {
            //Set up
            double num1 = 5;
            double num2 = 0;
            
            // Test
            double result = Calculator.Division(num1,num2);
            
            //Result
            Assert.Equal(0,result);
        }
        [Fact]
        public void Multiplication_Double_PositiveNumbers()
        {
            //Set up
            double num1 = 5;
            double num2 = 2;
            
            // Test
            double result = Calculator.Multiplication(num1,num2);
            
            //Result
            Assert.Equal(10,result);
        }
        
        [Fact]
        public void Multiplication_Double_NegativeNumbers()
        {
            //Set up
            double num1 = -5;
            double num2 = 2;
            
            // Test
            double result = Calculator.Multiplication(num1,num2);
            
            //Result
            Assert.Equal(-10,result);
        }
    }
}