using System;
using System.Collections.Generic;
using System.IO;
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

    public class Person
    {
        public string firstName = "Paul";
        public string lastNme = "Fox";
        public string email = "Mombasa3d@gmail.com";
        public bool status = true;
        public int idNo;

        public Person(int id)
        {
            idNo = id;
        }
    }


    class ScratchConsole
    {
        public static void Run()
        {
            int idCount = 0;
            do
            {
                PersonWrite(new Person(idCount));
                idCount += 1;
            } while (idCount < 1002);
        }

        public static void PersonWrite(Person subject)
        {
            string fileIn = subject.firstName + " " + subject.lastNme + "\n" +
                subject.email + "\n" +
                subject.status + "\n" +
                subject.idNo;
            File.WriteAllText("C:\\Users\\Mooba\\Documents\\DBTTest\\" + subject.idNo + ".txt", fileIn);

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
