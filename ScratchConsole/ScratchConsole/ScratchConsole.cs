using System;
using System.Collections.Generic;
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

            ////Select Random Enum 
            //Random rando = new Random();
            //DemoEnum[] demos = (DemoEnum[])Enum.GetValues(typeof(DemoEnum));

            //DemoEnum castEnum = (DemoEnum)Enum.Parse(typeof(DemoEnum), "First");

            //foreach (DemoEnum demo in demos)
            //{
            //    Console.WriteLine(demo);
            //}
            //List<int> numList = new List<int>();
            //Console.WriteLine("Count: ");
        }

        public static string ListParse(List<int> i)
        {
            string listInput = "";
            int count = 0;
            foreach(int u in i)
            {
                if(count >= 5)
                {
                    listInput += "\n";
                    count = 0;
                }
                listInput += u + " ";
                count++;
            }
            return listInput;
        }

    }
}
