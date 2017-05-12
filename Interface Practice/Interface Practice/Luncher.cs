using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Practice
{
    class Luncher
    {
        public static void Main(string[] args)
        {
            int mainArg = int.Parse(args[0]);
            if (mainArg == 2)
            {
                Program prog = new Program(new PrettyConsole());
                Program.Run();
            }
            else if(mainArg == 3)
            {
                Program prog = new Program(new AngryConsole());
                Program.Run();
            }
            else
            {
                Program proge = new Program(new PirateConsole());
                Program.Run();
            }
        }
    }
}
