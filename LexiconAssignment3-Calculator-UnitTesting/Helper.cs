﻿using System;
using System.Collections.Generic;

namespace UnboundKey.Core
{
    public static class Helper
    {
        /// <summary>
        /// This string will print to the console and then return the input from the user as a string
        /// </summary>
        /// <param name="printString"></param>
        /// <returns></returns>
        public static string ConWriteLineRead(string printString)
        {
            Console.WriteLine(printString);
            return Console.ReadLine();
        }
        public static string ConWriteRead(string printString)
        {
            Console.Write(printString);
            return Console.ReadLine();
        }
        /// <summary>
        /// This will try to parse an int from the passed in string, if it failes it will print an error message to console, and return a 0 as a fallback value
        /// </summary>
        /// <param name="ParseString"></param>
        /// <returns></returns>
        public static int ParseInt(this string ParseString)
        {
            int conSelection = 0;
            try
            {
                conSelection = int.Parse(ParseString);
            }
            catch
            {
                Console.WriteLine("Cannot parse input string, please use numbers");
            }
            return conSelection;
        }

        /// <summary>
        /// This will try to parse an int from the passed in string and if it fails print an error message, and return the fallback value specified
        /// </summary>
        /// <param name="ParseString"></param>
        /// <param name="FallbackValue"></param>
        /// <returns></returns>
        public static int ParseInt(this string ParseString, int FallbackValue)
        {
            int conSelection = FallbackValue;
            try
            {
                conSelection = int.Parse(ParseString);
            }
            catch
            {
                Console.WriteLine("Cannot parse input string, please use numbers");
            }
            return conSelection;
        }

        public static int ParseInt(this string ParseString, string ErrorMessage)
        {
            int conSelection = 0;
            try
            {
                conSelection = int.Parse(ParseString);
            }
            catch
            {
                Console.WriteLine(ErrorMessage);
            }
            return conSelection;
        }

        public static float ParseFloat(this string ParseString)
        {
            float conSelection = 0;
            try
            {
                conSelection = float.Parse(ParseString);
            }
            catch
            {
                Console.WriteLine("Cannot parse input string, please use numbers");
            }
            return conSelection;
        }

        public static float ParseFloat(this string ParseString, float FallbackValue)
        {
            float conSelection = FallbackValue;
            try
            {
                conSelection = float.Parse(ParseString);
            }
            catch
            {
                Console.WriteLine("Cannot parse input string, please use numbers");
            }
            return conSelection;
        }


        public static float ParseFloat(this string ParseString, string ErrorMessage)
        {
            float conSelection = 0;
            try
            {
                conSelection = float.Parse(ParseString);
            }
            catch
            {
                Console.WriteLine(ErrorMessage);
            }
            return conSelection;
        }
        public static float ParseFloat(this string ParseString, int fallbackValue, string ErrorMessage)
        {
            float conSelection = fallbackValue;
            try
            {
                conSelection = float.Parse(ParseString);
            }
            catch
            {
                Console.WriteLine(ErrorMessage);
            }
            return conSelection;
        }
        public static double ParseDouble(this string ParseString)
        {
            double returnValue = 0;
            try
            {
                returnValue = double.Parse(ParseString);
            }
            catch
            {
                Console.WriteLine("Cannot parse input string, returning 0");
            }
            return returnValue;
        }

        public static double ParseDouble(this string ParseString, int fallBackValue)
        {
            double returnValue = fallBackValue;
            try
            {
                returnValue = double.Parse(ParseString);
            }
            catch
            {
                Console.WriteLine("Cannot parse input string, returning 0");
            }
            return returnValue;
        }

        public static double ParseDouble(this string ParseString, int fallBackValue, string errorMessage)
        {
            double returnValue = fallBackValue;
            try
            {
                returnValue = double.Parse(ParseString);
            }
            catch
            {
                Console.WriteLine(errorMessage);
            }
            return returnValue;
        }
        
        public static double ParseDouble(this string ParseString, string errorMessage)
        {
            double returnValue = 0;
            try
            {
                returnValue = double.Parse(ParseString);
            }
            catch
            {
                Console.WriteLine(errorMessage);
            }
            return returnValue;
        }
        
        public static string StringFlipper(string Input)
        {
            string reversedInput = "";
            for (int i = Input.Length; i > 0; i--)
            {
                reversedInput += Input[i - 1];
            }
            return reversedInput;
        }

        public static int[] SortArray(int[] unsortedIntArray)
        {
            int[] sortedInts = new int[unsortedIntArray.Length];
            int tempStorage;
            for (int i = 0; i < unsortedIntArray.Length; i++)
            {
                sortedInts[i] = unsortedIntArray[i];
            }

            for (int i = 0; i < sortedInts.Length; i++)
            {
                for (int j = i + 1; j < sortedInts.Length; j++)
                {
                    if (sortedInts[i] > sortedInts[j])
                    {
                        //Console.WriteLine(string.Format("i:{0} j:{1} i value: {2} j value: {3}", i, j, randomArray[i], randomArray[j]));
                        tempStorage = sortedInts[i];
                        sortedInts[i] = sortedInts[j];
                        sortedInts[j] = tempStorage;
                    }

                }

            }

            return sortedInts;
        }
        public static List<int> SortList(List<int> unsortedIntArray)
        {
            List<int> sortedInts = new List<int>();
            int tempStorage;
            for (int i = 0; i < unsortedIntArray.Count; i++)
            {
                //sortedInts[i] = unsortedIntArray[i];
                sortedInts.Add(unsortedIntArray[i]);
            }

            for (int i = 0; i < sortedInts.Count; i++)
            {
                for (int j = i + 1; j < sortedInts.Count; j++)
                {
                    if (sortedInts[i] > sortedInts[j])
                    {
                        //Console.WriteLine(string.Format("i:{0} j:{1} i value: {2} j value: {3}", i, j, randomArray[i], randomArray[j]));
                        tempStorage = sortedInts[i];
                        sortedInts[i] = sortedInts[j];
                        sortedInts[j] = tempStorage;
                    }

                }

            }

            return sortedInts;
        }
        
        public static string[] ToStringArray(this string inputString)
        {
            string[] numbers = inputString.Split(',');
            return numbers;
        }
        public static string[] ToStringArray(this string inputString, char separatorCharacter)
        {
            string[] numbers = inputString.Split(separatorCharacter);
            return numbers;
        }

        
    }
}