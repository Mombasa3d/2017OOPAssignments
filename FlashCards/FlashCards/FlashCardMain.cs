using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleIO;

namespace FlashCards
{
    class FlashCardMain
    {
        private static Random rando = new Random();
        private static string[] manageList = new string[] { "Add card", "Remove card", "Save cards", "Main Menu" };
        private static List<string> menuList = new List<string> { "Manage Flash Cards", "Review", "Exit" };
        private static Dictionary<string, FlashCard> cardBank = new Dictionary<string, FlashCard>();
        private static List<string> hashKeys = new List<string>();

        public static void FlashCardPrompt()
        {
            int menuChoice = ConsoleIO.CIO.PromptForMenuSelection(menuList, true);

            switch(menuChoice)
            {
                case 1:
                    ManageMenu(menuChoice);
                    break;
                case 2:
                    Review();
                    break;
                default:
                    break;
            }
        }

        private static void Review()
        {

        }

        private static void ManageMenu()
        {
            ConsoleIO.CIO.PromptForMenuSelection(manageList, false);
            switch()
        }
    }
}
