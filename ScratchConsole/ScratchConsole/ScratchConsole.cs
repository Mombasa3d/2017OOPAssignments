using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Namespace: Virtual equivalent to Packages

    /*
     *  Block comment
     */
namespace ScratchConsole
{

    public enum DemoEnum
    {
        First,
        Second,
        Third
    }

    class ScratchConsole
    {
        public static void Run()
        {
            //Select Random Enum 
            Random rando = new Random();
            DemoEnum[] demos = (DemoEnum[])Enum.GetValues(typeof(DemoEnum));

            DemoEnum castEnum = (DemoEnum)Enum.Parse(typeof(DemoEnum), "First");

            foreach(DemoEnum demo in demos)
            {
                Console.WriteLine(demo);
            }
        }
    }
}
