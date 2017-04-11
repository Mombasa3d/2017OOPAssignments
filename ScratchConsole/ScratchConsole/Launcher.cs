using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchConsole
{
    class Launcher
    {
        static void Main()
        {
            bool validIn = false;
            string userIn;
            do
            {

            } while (!validIn);
        }

        public static void ArrayGen(int[] arr, int min, int max)
        {
            if(arr == null)
            {
                Console.WriteLine("Input array is null, aborting operation");
            }
            else
            {
                Random rando = new Random();
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = rando.Next(min, max + 1);
                }
            }
            
        }

        public static void Printer(int[] arrayInts)
        {
            if (arrayInts == null)
            {
                
            }
            else
            {
                foreach (int num in arrayInts)
                {
                    Console.WriteLine(num);
                }
            }

        }
        //public static long MultiplyNumbers(int[] nums)
        //{
        //    //Return the product of these numbers (from the nums array)
        //    long productFinal = 1;
        //    foreach (int i in nums)
        //    {
        //        productFinal *= i;
        //    }

        //    return productFinal;
        //}
    }
}
