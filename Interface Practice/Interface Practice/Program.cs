using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Practice
{
    class Program
    {
        public static IConsoleViewable ClassICV;
        public static void Run()
        {
            string ICVInput = ClassICV.PromptForInput();
            ClassICV.PrintInput(ICVInput);
        }



        public Program(IConsoleViewable ICVvar)
        {
            ClassICV = ICVvar;
        }
    }
}
