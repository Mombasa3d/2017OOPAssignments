using System;
using System.Collections.Generic;

namespace CSC150_ConsoleMenu
{
    public static class CIO
    {
        public static int promptForMenuSelection(String prompt, String[] options, bool withQuit)
        {
            bool validInput = false;
            bool validEntry = true;
            int menuPick = 0;
            int menuCount = 0;
            Console.WriteLine(prompt);
            do
            {
                int menuIndex = 1;
                foreach (String i in options)
                {
                    Console.WriteLine(menuIndex + ") " + i);
                    menuIndex++;
                    menuCount++;
                }
                if (withQuit)
                {
                    Console.WriteLine("\n0) Quit");
                }
                do
                {
                    try
                    {
                        menuPick = Int32.Parse(Console.ReadLine());
                        validEntry = true;
                    }
                    catch (ArgumentException)
                    {
                        Console.WriteLine("Please pick a valid menu option!");
                        validEntry = false;
                    }
                } while (!validEntry);
                if (menuPick > menuCount || menuPick < 0)
                {
                    Console.WriteLine("Please pick a valid menu option! (0 - " + menuIndex + ")");
                }
                else
                {
                    validInput = true;
                }
            } while (!validInput);
            return menuPick;
        }

        public static bool PromptForBool(string message, string trueString, string falseString)
        {
            bool validBool = false;
            string userIn = "";
            do
            {
                Console.WriteLine(message);
                try
                {
                    userIn = Console.ReadLine();
                    validBool = (userIn == null | userIn.Equals("")) ? true : false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter either (" + trueString + ") or (" + falseString + ")");
                }
                validBool = (userIn.ToLower().Equals(trueString.ToLower()) | userIn.ToLower().Equals(falseString.ToLower())) ? true : false;
            } while (!validBool);
            bool result = (userIn.ToLower().Equals(trueString.ToLower())) ? true : false;
            return result;
        }

        public static byte PromptForByte(string message, byte min, byte max)
        {
            return (byte)PromptForDecimal(message, min, max);
        }

        public static short PromptForShort(string message, short min, short max)
        {
            return (short)PromptForDecimal(message, min, max);
        }

        public static int PromptForInt(string message, int min, int max)
        {
            return (int)PromptForDecimal(message, min, max);
        }

        public static long PromptForLong(string message, long min, long max)
        {
            return (long)PromptForDecimal(message, min, max);
        }

        public static float PromptForFloat(string message, float min, float max)
        {
            return (float)PromptForDecimal(message, (decimal)min, (decimal)max);
        }

        public static double PromptForDouble(string message, double min, double max)
        {
            return (double)PromptForDecimal(message, (decimal)min, (decimal)max);
        }

        public static decimal PromptForDecimal(string message, decimal min, decimal max)
        {
            bool validInput = false;
            decimal userChoice = 0;
            Console.WriteLine(message);
            do
            {
                try
                {
                    userChoice = decimal.Parse(Console.ReadLine());
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Please enter a valid decimal between " + min + " and " + max);
                }
                if (userChoice > max || userChoice < min)
                {
                    Console.WriteLine("Please enter a valid decimal between " + min + " and " + max);
                }
                else
                {
                    validInput = true;
                }
            } while (!validInput);

            return userChoice;
        }

        public static string PromptForInput(string message, bool allowEmpty)
        {
            bool validIn = false;
            string userIn = "";
            do
            {
                Console.WriteLine(message);
                userIn = Console.ReadLine();
                if(allowEmpty)
                {
                    userIn = userIn ?? "";
                    validIn = true;
                }
                else
                {
                    validIn = (userIn == null | userIn.Equals("")) ? false : true;
                }
            } while (!validIn);
            return userIn;
        }

        public static char PromptForChar(string message, char min, char max)
        {
            bool validIn = false;
            char userChar = ' ';
            do
            {
                Console.WriteLine(message);
                userChar = Console.ReadKey().KeyChar;
                Console.WriteLine();
                if(char.IsDigit(userChar) == true)
                {
                    Console.WriteLine("Input must be an alphabetical character.");
                }
                else if (userChar.GetHashCode() < min.GetHashCode() | userChar.GetHashCode() > max.GetHashCode())
                {
                    Console.WriteLine("Input must be between " + min + " and " + max);
                }
                else
                {
                    validIn = true;
                }
            } while (!validIn);
            return userChar;
        }
    }
}
