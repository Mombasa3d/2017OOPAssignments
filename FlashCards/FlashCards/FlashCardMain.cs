using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleIO;

namespace FlashCards
{
    using System.Diagnostics;
    using System.IO;
    using System.Xml.Linq;

    class FlashCardMain
    {
        private static Random rando = new Random();
        private static string[] manageList = new string[] { "Add card", "Remove card", "Save cards", "Load cards", "Main Menu" };
        private static List<string> menuList = new List<string> { "Manage Flash Cards", "Review", "Exit" };
        private static Dictionary<string, string> cardBank = new Dictionary<string, string>();
        private static List<string> hashKeys = new List<string>();

        public static void FlashCardPrompt()
        {
            bool activeMenu = true;
            do
            {
                Console.WriteLine("Number of cards in current deck: " + cardBank.Keys.Count);
                int menuChoice = ConsoleIO.CIO.PromptForMenuSelection(menuList, true);

                switch (menuChoice)
                {
                    case 1:
                        ManageMenu();
                        break;
                    case 2:
                        Review();
                        break;
                    case 0:
                        activeMenu = false;
                        break;
                }
            }
            while (activeMenu);
        }

        private static void Review()
        {
            bool activeReview = true;
            bool validChar = false;
            do
            {
                char reviewChoice;
                string reviewKey = cardBank.Keys.ElementAt(rando.Next(cardBank.Count));
                Console.WriteLine(reviewKey + "\n Please press enter to display the definition of " + reviewKey);
                do
                {
                }
                while (Console.ReadKey().Key != ConsoleKey.Enter);
                //Console.WriteLine(cardBank.TryGetValue(reviewKey, out reviewKey));
                Console.WriteLine(cardBank[reviewKey]);
                Console.WriteLine("\nPress [Enter] to display a new card or [b] to return to the main menu:");
                do
                {
                    reviewChoice = Console.ReadKey().KeyChar;
                    validChar = reviewChoice == 'b' || reviewChoice == 13 ? true : false;
                }
                while (!validChar);
                if (reviewChoice == 'b')
                {
                    activeReview = false;
                }
            }
            while (activeReview);

        }

        private static void ManageMenu()
        {
            bool manageActive = true;
            do
            {
                int manageChoice = ConsoleIO.CIO.PromptForMenuSelection(manageList, false);
                switch (manageChoice)
                {
                    case 1:
                        AddCard();
                        manageActive = false;
                        break;
                    case 2:
                        RemoveCard();
                        manageActive = false;
                        break;
                    case 3:
                        Console.WriteLine("Please enter save file path: (filepath and filename) ");
                        SaveCards(Console.ReadLine());
                        manageActive = false;
                        break;
                    case 4:
                        Console.WriteLine("Please enter load path: (ex: C:\\directory\\file.txt) ");
                        LoadCards(Console.ReadLine());
                        manageActive = false;
                        break;
                    case 5:
                        manageActive = false;
                        break;
                }
            }
            while (manageActive);

        }

        private static void AddCard()
        {
            Console.WriteLine("Please enter the name of the new flash card: ");
            string cardIn = Console.ReadLine();
            if (cardBank.ContainsKey(cardIn))
            {
                Console.WriteLine("Card already exists! Returning to Main Menu...");
            }
            else
            {
                Console.WriteLine("Please enter the definition of the new card: ");
                string userDef = Console.ReadLine();
                cardBank.Add(cardIn, userDef);
            }
        }

        private static void RemoveCard()
        {
            Console.WriteLine("Please enter the name of the card you would like to delete: ");
            string inputKey = Console.ReadLine();
            if (cardBank.ContainsKey(inputKey))
            {
                cardBank.Remove(inputKey);
                Console.WriteLine(inputKey + " has been successfully deleted!");
            }
            else
            {
                Console.WriteLine("[CARD] " + inputKey + " was not found....");
            }
        }

        private static void SaveCards(string filePath)
        {
            if (string.IsNullOrEmpty(Path.GetFullPath(filePath)))
            {
                Console.WriteLine("Invalid file path, returning to main menu...");
            }
            else
            {
                //File.Create(filePath);
                StringBuilder saveString = new StringBuilder();
                foreach (string i in cardBank.Keys)
                {
                    saveString.Append(i + " :: " + cardBank[i]);
                    saveString.AppendLine();
                }
                File.WriteAllText(filePath, saveString.ToString());
            }
        }

        private static void LoadCards(string filePath)
        {
            if (File.Exists(filePath))
            {
                cardBank.Clear();
                StringBuilder verifyLoad = new StringBuilder();
                StringBuilder dupliKeys = new StringBuilder();
                verifyLoad.Append("Successfully loaded cards: \n");
                string[] fileLines = File.ReadAllLines(filePath);
                string[] separators = new string[] { " :: " };
                foreach (string i in fileLines)
                {
                    string opString = i.Trim();
                    string[] keyAndVal = opString.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                    if (!cardBank.ContainsKey(keyAndVal[0]))
                    {
                        cardBank.Add(keyAndVal[0], keyAndVal[1]);
                        verifyLoad.Append(keyAndVal[0] + "\n");
                    }
                    else
                    {
                        dupliKeys.Append(keyAndVal[0]);
                    }
                }
                Console.WriteLine(verifyLoad.ToString());
            }
            else
            {
                Console.WriteLine("File not found at " + filePath + ", returning to main menu");
            }
        }
    }

}
