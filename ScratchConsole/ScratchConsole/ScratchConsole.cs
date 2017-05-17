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

            //Select Random Enum 
            //Random rando = new Random();
            //DemoEnum[] demos = (DemoEnum[])Enum.GetValues(typeof(DemoEnum));

            //DemoEnum castEnum = (DemoEnum)Enum.Parse(typeof(DemoEnum), "First");

            //foreach (DemoEnum demo in demos)
            //{
            //    Console.WriteLine(demo);
            //}
            //List<int> numList = new List<int>();
            //Console.WriteLine("Count: ");
            //Console.WriteLine(StringRecursion("Moobadoo"));

            int[,] tdNums = new int[10, 14];

            int counter = 0;
            int horiz = 0;
            string print2D = "";
            for (int i = 0; i < 10; i++)
            {
                print2D = "";   
                for (int j = 0; j < 14; j++)
                {
                    tdNums[i, j] = counter;
                    print2D += tdNums[i, j] + " ";
                    counter++;
                }
                Console.WriteLine(print2D);
            }

            foreach(int i in tdNums)
            {
                Console.WriteLine(i);
            }
        }
    }

    //public static string StringRecursion(string r)
    //{
    //    string rev = "";
    //    if (r.Length == 0)
    //    {
    //        return rev;
    //    }
    //    else
    //    {
    //        r.Remove(0, 1);
    //        rev = StringRecursion(r);
    //    }

    //}

    //public static int AddRecursion(int a, int b)
    //{
    //    if (b == 0)
    //    {
    //        return a;
    //    }
    //    else
    //    {
    //        int c = AddRecursion(++a, --b);
    //    }
    //}


}
