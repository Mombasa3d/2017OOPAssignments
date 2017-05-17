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
            Console.WriteLine("Welcome to Connect Four!\nWhat type of game would you like to play?");
            int mainMenuChoice = ConsoleIO.CIO.PromptForMenuSelection(new string[] { "Player vs. Player", "Player vs. AI", "AI vs. AI" }, true);
            bool activeGame = true;
            switch (mainMenuChoice)
            {
                case 1:
                    do
                    {

                    } while (activeGame);
                    break;
                case 2:
                    do
                    {

                    } while (activeGame);
                    break;
                case 3:
                    do
                    {

                    } while (activeGame);
                    break;
                case 0:
                    break;
            }
        }

        public static void InGameMenu()
        {

        }

        public static void PostgameCarnageReport()
        {

        }
    }
}
