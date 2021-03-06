﻿using System;
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
        private static string[] manageList = new string[] { "Add card", "Remove card", "Save cards", "Load cards", "Reset card", "Reset all cards", "Main Menu" };
        private static List<string> menuList = new List<string> { "Manage Flash Cards", "Review cards", "Review [Hard] cards", "Progress Report", "Exit" };
        private static Dictionary<string, FlashCard> cardBank = new Dictionary<string, FlashCard>();
        private static Dictionary<string, FlashCard> hardBank = new Dictionary<string, FlashCard>();
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
                        if (cardBank.Count() > 0)
                        {
                            Review(cardBank);
                        }
                        else
                        {
                            Console.WriteLine("There are no cards in this deck...");
                        }
                        break;
                    case 3:
                        if (hardBank.Count() > 0)
                        {
                            Review(hardBank);
                        }
                        else
                        {
                            Console.WriteLine("There are no hard cards in this deck...");
                        }
                        break;
                    case 4:
                        if (cardBank.Count > 0)
                        {
                            ProgressReport();
                        }
                        else
                        {
                            Console.WriteLine("There are no cards to review! Please load or add some cards first.");
                        }
                        break;
                    case 0:
                        activeMenu = false;
                        break;
                }
            }
            while (activeMenu);
        }

        private static void Review(Dictionary<string, FlashCard> bank)
        {
            bool activeReview = true;
            bool validChar = false;
            do
            {
                char reviewChoice;
                string reviewKey = bank.Keys.ElementAt(rando.Next(cardBank.Count));
                bank[reviewKey].AttemptCount += 1;
                Console.WriteLine(reviewKey + "\n Please press enter to display the definition of " + reviewKey);
                do
                {
                }
                while (Console.ReadKey().Key != ConsoleKey.Enter);
                //Console.WriteLine(cardBank.TryGetValue(reviewKey, out reviewKey));
                Console.WriteLine(bank[reviewKey].Definition.ToString());
                bool isCorrect = ConsoleIO.CIO.PromptForBool("Did you successfully guess the definition of " + reviewKey + "?", "Y", "N");
                bank[reviewKey].SuccessCount += (isCorrect) ? 1 : 0;
                if (bank[reviewKey].Mastery() <= 70.0 && !hardBank.ContainsKey(reviewKey))
                {
                    hardBank.Add(reviewKey, bank[reviewKey]);
                }
                else if (bank[reviewKey].Mastery() > 70.0 && hardBank.ContainsKey(reviewKey))
                {
                    hardBank.Remove(reviewKey);
                }
                Console.WriteLine("\nPress [Enter] to display a new card or [b] to return to the main menu:");
                do
                {
                    reviewChoice = Console.ReadKey().KeyChar;
                    validChar = reviewChoice == 'b' || reviewChoice == 13 ? true : false;
                }
                while (!validChar);
                if (reviewChoice == 'b' || bank.Count() < 1)
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
                        if (cardBank.Count > 0)
                        {
                            Console.WriteLine("Please enter save file path: (filepath and filename) ");
                            SaveCards(Console.ReadLine());
                            manageActive = false;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("There are no cards to save");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Please enter load path: (ex: C:\\directory\\file.txt) ");
                        LoadCards(Console.ReadLine());
                        manageActive = false;
                        break;
                    case 5:
                        ResetCard(ConsoleIO.CIO.PromptForInput("Which card would you like to delete?", false));
                        break;
                    case 6:
                        ResetAll(cardBank);
                        break;
                    case 7:
                        manageActive = false;
                        break;
                }
            }
            while (manageActive);

        }

        private static void ProgressReport()
        {
            List<FlashCard> progList = new List<FlashCard>();
            foreach (string i in cardBank.Keys)
            {
                progList.Add(cardBank[i]);
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < cardBank.Count - 1; j++)
                {
                    if (progList[j].Mastery() > progList[j + 1].Mastery())
                    {
                        FlashCard temp = progList[j];
                        progList[j] = progList[j + 1];
                        progList[j + 1] = temp;
                    }
                }
            }
            foreach (FlashCard f in progList)
            {
                Console.WriteLine(f.Keyword + ": " + f.Mastery().ToString("F"));
            }
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
                cardBank.Add(cardIn, new FlashCard(cardIn, userDef));
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
                    saveString.Append(" :: " + cardBank[i].Definition + " :: " + cardBank[i].AttemptCount + " :: " + cardBank[i].SuccessCount);
                    saveString.AppendLine();
                }
                File.WriteAllText(filePath, saveString.ToString());
            }
        }

        private static void ResetCard(string card)
        {
            if (hashKeys.Contains(card))
            {
                cardBank.Remove(card);
                Console.WriteLine("${card} was successfully removed!");
            }
            else
            {
                Console.WriteLine("$Card {card} does not exist in the deck, returning to menu...");
            }
        }

        private static void ResetAll(Dictionary<string, FlashCard> deck)
        {
            foreach (string i in hashKeys)
            {
                deck[i].ResetMastery();
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
                        cardBank.Add(keyAndVal[0], new FlashCard(keyAndVal[0], keyAndVal[1]));
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
