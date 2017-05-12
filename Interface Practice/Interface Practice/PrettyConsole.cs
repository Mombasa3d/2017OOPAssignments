using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Practice
{
    class PrettyConsole : IConsoleViewable
    {
        public void PrintInput(string input)
        {
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.WriteLine(input);
        }

        public string PromptForInput()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            string userIn = ConsoleIO.CIO.PromptForInput("Hail Courtier! Present to me information that might feed my insatiable craving for gossip and tomfoolery.", false);
            return userIn;
        }
    }
}
