﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProgUtilLib
{
    public class ProgramUtil
    {

        public static int ParseInt(string input)
        {
            if(string.IsNullOrEmpty(input))
            {
                throw new ArgumentException("Input is either null or empty");
            }
            bool negative = false;
            String origInput = input;
            input = input.Trim();
            if (input.First() == '-')
            {
                negative = true;
            }
            input = input.Trim();
            char[] inputArray = input.ToCharArray();
            long returnInt = 0;
            long exponentMulti = 0;
            for (int i = inputArray.Length - 1; i >= ((negative) ? 1 : 0); i--)
            {   
                if (inputArray[i] >= '!' && inputArray[i] < '0' || inputArray[i] > '9' && inputArray[i] < 'A'
                        || inputArray[i] > 'Z' && inputArray[i] < 'a' || inputArray[i] > 'z')
                {
                    throw new FormatException("Input " + input + " contains special characters!\n");
                }
                else if (inputArray[i] > '@' && inputArray[i] < '[' || inputArray[i] >= 'a' && inputArray[i] <= 'z')
                {
                    throw new FormatException("Input " + input + " contains letters!\n");
                }
                long temp = inputArray[i] - '0';
                temp *= (long)(Math.Pow(10, exponentMulti));
                if (temp > Int32.MaxValue || (temp * -1) < Int32.MinValue)
                {
                    throw new FormatException("Input " + origInput + " is too large/small to be an integer!");
                }
                returnInt += temp;
                exponentMulti++;
            }
            if (negative)
            {
                returnInt *= -1;
            }
            if (returnInt > Int32.MaxValue || returnInt < Int32.MinValue)
            {
                throw new FormatException("Input " + input + "is too large/small to be an integer!");
            }
            return (int)returnInt;
        }

        public static TryParseIntResult TryParseInt(string input)
        {
            int parseValue;
            try
            {
                parseValue = ParseInt(input);
            }
            catch (FormatException)
            {
                return new TryParseIntResult(false, null);
            }
            return new TryParseIntResult(true, parseValue);
        }


        public static long Factorial(int num)
        {
            if (num < 0 || num > 20)
            {
                throw new ArgumentException("Arguement must not be less than 0 or greater than 20");
            }
            else
            {
                long result;
                if (num == 0 || num == 1)
                {
                    return 1;
                }
                result = Factorial(num - 1) * num;
                return result;
            }
        }

        public static string ReadFile(string filePath)
        {
            if (filePath == null || !File.Exists(filePath))
            {
                throw new FileNotFoundException("File not found at path " + filePath);
            }
            byte[] fileIn = File.ReadAllBytes(filePath);
            string returnString = System.Text.Encoding.UTF8.GetString(fileIn);
            return returnString;
        }

        public static void WriteToFile(string filePath, string output)
        {
            if (string.IsNullOrEmpty(Path.GetFullPath(filePath)))
            {
                throw new DirectoryNotFoundException("File path (" + filePath + ") is invalid");
            }

            File.WriteAllText(filePath, output);

        }
    }
}
