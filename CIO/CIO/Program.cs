using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIO
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] choices = new string[]
            {
                "Test", "Exit", "Testingo"
            };
            Console.WriteLine(CSC150_ConsoleMenu.CIO.PromptForBool("Is this true or false?", "Troof", "Lies"));
        }
    }
}
