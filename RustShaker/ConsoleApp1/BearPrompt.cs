using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RustShaker.Enums;
using RustShaker.Models;

namespace RustShaker
{
    class BearPrompt
    {
        private static Random rando = new Random(0);

        private static string[] nameArr = new string[]
        {
            "Ursaring", "Beartic", "Teddiursa", "Bewear", "Cubchoo", "Pangoro", "Pancham", "Spinda", "Snorlax", "Munchlax"
        };

        private static string[] colorArr = new string[]
        {
            "Red", "Blue", "Purple", "White", "Green", "Yellow", "Orange"
        };
        public static void BuildABear()
        {
            bool activeApp = true;
            do {
                Console.WriteLine("Welcome to Ursineagen!\n" + "\nPlease choose an option: " + "\n1) Generate Random Bear " + "\n2) Generate Default Bear" +
                    "\n\n0) Exit");
                int userChoice = Convert.ToInt32(Console.ReadLine());
                switch(userChoice)
                {
                    case 1:
                        Bear randoBear = UrsineGen();
                        Console.WriteLine(randoBear.ToString());
                        break;
                    case 2:
                        Bear defaultBurr = new Bear();
                        Console.WriteLine(defaultBurr.ToString()); 
                        break;
                    case 0:
                        Console.WriteLine("Goodbye!");
                        activeApp = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid menu choice!");
                        break;
                }
            } while(activeApp);
        }

        private static Bear UrsineGen()
        {
            Array colorEnums = Enum.GetValues(typeof(BearType));
            BearType randomType = (BearType)colorEnums.GetValue(rando.Next(0, colorEnums.Length));
            Bear chaosBear = new Bear(colorArr.GetValue(rando.Next(0, colorArr.Length)).ToString(), nameArr.GetValue(rando.Next(0, nameArr.Length)).ToString(), ((float)rando.NextDouble() * 500),
                rando.Next(5000), randomType);
            return chaosBear;
        }
    }
}
