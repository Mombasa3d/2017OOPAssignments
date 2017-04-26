using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSC150_ConsoleMenu;

namespace CIO
{
    class Luncher
    {
        public static void Main()
        {
            string[] choices = new string[]
            {
                "Abc", "Def", "Ghi", "Jkl"
            };
            CSC150_ConsoleMenu.CIO.PromptForMenuSelection(choices, true);

    }
}
}
