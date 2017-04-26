using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgUtilLib;
using ;

namespace ScratchConsole
{
    class Launcher
    {
        static void Main()
        {
            List<String> sList = new List<string> { "Stri", "ngs", "Are", "Okay" };
            Console.WriteLine(CSC150_ConsoleMenu.CIO.PromptForMenuSelection(sList, false));
        }
    }
}
