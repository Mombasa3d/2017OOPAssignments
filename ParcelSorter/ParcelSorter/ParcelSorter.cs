using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcelSorter
{
    class ParcelSorter
    {
        private static int promptTotal;
        private static string[] reMenu = new string[]
        {
            "Sort More Parcels"
        };
        private static List<Parcel> UPS = new List<Parcel>();
        public static void ParcelPrompt()
        {
            bool activeSorter = true;
            do
            {

                promptTotal = ConsoleIO.CIO.PromptForInt("How many parcels would you like to create?", 1, int.MaxValue);
                for (int i = 0; i < promptTotal; i++)
                {
                    Console.WriteLine("Package (" + (i + 1) + ")");
                    UPS.Add(new Parcel(
                        ConsoleIO.CIO.PromptForFloat("Please enter the package's weight: ", 0.2f, float.MaxValue),
                        ConsoleIO.CIO.PromptForFloat("Please enter the package's height: ", 0.1f, float.MaxValue),
                        ConsoleIO.CIO.PromptForFloat("Please enter the package's width: ", 0.1f, float.MaxValue),
                        ConsoleIO.CIO.PromptForFloat("Please enter the package's depth: ", 0.1f, float.MaxValue))
                        );
                }
                UPS = Sorterize(UPS);
                foreach(Parcel p in UPS)
                {
                    Console.WriteLine(p.ToString());
                }
                UPS.Clear();
                activeSorter = ConsoleIO.CIO.PromptForMenuSelection(reMenu, true) == 1 ? true : false ;
            } while(activeSorter);
        }

        private static List<Parcel> Sorterize(List<Parcel> parcels)
        {
            for(int i = (promptTotal - 1); i >= 1; i--)
            {
                if(parcels[i].CompareTo(parcels[i - 1]) == 1)
                {
                    Parcel tempParcel = parcels[i - 1];
                    parcels[i - 1] = parcels[i];
                    parcels[i] = tempParcel;
                }
            }
            return parcels;
        }
    }
}
