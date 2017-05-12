using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Practice
{
    class AngryConsole : IConsoleViewable
    {
        public void PrintInput(string input)
        {
            Console.WriteLine(input.ToUpper());
        }

        public string PromptForInput()
        {
            return ConsoleIO.CIO.PromptForInput("BOI, WOTCHU WANT?!", false);

        }
    }
}
