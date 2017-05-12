using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFour.Models
{
    class UI
    {
        public static void PrintBoard(Board bord, bool colDisp)
        {
            if (colDisp)
            {
                Console.WriteLine(" 1 2 3 4 5 6 7");
            }
            for (int i = 0; i < bord.RowCount; i++)
            {
                String bordPrint = "";
                for (int j = 0; j < bord.ColumnCount; j++)
                {
                    bordPrint += "|";
                    bordPrint += (bord.Grid[j, i] == Chip.None) ? " " : bord.Gr[j, i].ToString();
                }
                Console.WriteLine(bordPrint + "|");
            }
        }

        public static void MainMenu()
        {

        }

        public static void InGameMenu()
        {

        }

        public static void PostgameCarnageReport()
        {

        }
    }
}
