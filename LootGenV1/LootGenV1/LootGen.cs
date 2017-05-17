using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LootGenV1
{
    class LootGen
    {
        private static Random randomize = new Random();
        private static string[] mainOptions = new string[] { "Generate [1] loot item", "Generate some loot items", "Generate [n] loot items" };
        private static List<Item> lootChest = new List<Item>();

        public static void MainMenu()
        {
            bool activeGen = true;
            do
            {
                Console.WriteLine("Welcome to LootGen v1!\n ");
                int mainChoice = ConsoleIO.CIO.PromptForMenuSelection(mainOptions, true);
                switch (mainChoice)
                {
                    case 1:
                        Generate(1, lootChest);
                        Console.WriteLine(PrintChest(lootChest));
                        break;
                    case 2:
                        Generate(randomize.Next(1, 11), lootChest);
                        Console.WriteLine(PrintChest(lootChest));
                        break;
                    case 3:
                        Generate(ConsoleIO.CIO.PromptForInt("How many loot items would you like to create?", int.MinValue, int.MaxValue), lootChest);
                        Console.WriteLine(PrintChest(lootChest));
                        break;
                    case 0:
                        activeGen = false;
                        break;
                }
                EmptyChest(lootChest);

            } while (activeGen);
        }

        private static void Generate(int amount, List<Item> chest)
        {
            for(int i = 0; i < amount; i++)
            {
                switch(randomize.Next(1, 5))
                {
                    case 1:
                        chest.Add(new Item());
                        break;
                    case 2:
                        chest.Add(new Armor());
                        break;
                    case 3:
                        chest.Add(new Weapon());
                        break;
                    case 4:
                        chest.Add(new Potion());
                        break;
                }
            }
        }

        private static void EmptyChest(List<Item> chest)
        {
            for(int i = 0; i < chest.Capacity; i++)
            {
                chest.Clear();
            }
        }

        private static string PrintChest(List<Item> chest)
        {
            StringBuilder chestSB = new StringBuilder();
            foreach (var item in chest)
            {
                chestSB.Append(item.ToString());
                chestSB.Append("\n");
            }
            return chestSB.ToString();
        }
    }
}
