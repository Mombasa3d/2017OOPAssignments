using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Practice
{
    class PirateConsole : IConsoleViewable
    {   
        public void PrintInput(string input)
        {
            Console.WriteLine(input.Replace("r", "-ARR-"));
        }

        public string PromptForInput()
        {
            string userString = ConsoleIO.CIO.PromptForInput("Torrenting games is not 'stealing', it's SHARING!!! Do you agree?!", false);
            Console.Beep();
            return userString;
        }
    }
}
