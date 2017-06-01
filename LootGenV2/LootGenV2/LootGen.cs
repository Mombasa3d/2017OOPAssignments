using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LootGenV2.Characters;
using LootGenV2.Items.Consumables;
using LootGenV2.Interfaces;

namespace LootGenV2
{
    class LootGen
    {
        private static Random randomize = new Random();
        private static string[] mainOptions = new string[] { "Generate [1] loot item", "Generate some loot items", "Generate [n] loot items", "Demonstrate consumables" };
        private static List<Item> lootChest = new List<Item>();

        public static void MainMenu()
        {
            bool activeGen = true;
            do
            {
                Console.WriteLine("Welcome to LootGen v2!\n ");
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
                    case 4:
                        Monk testChar = new Monk();
                        int randomFoe = randomize.Next(1, 3);
                        Character testFoe = null;
                        switch(randomFoe)
                        {
                            case 1:
                                testFoe = new Voidsent();
                                break;
                            case 2:
                                testFoe = new Automaton();
                                break;
                        }
                        Demonstrate(testChar, testFoe);
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
                switch(randomize.Next(1, 9))
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
                    case 5:
                        chest.Add(new Berserk());
                        break;
                    case 6:
                        chest.Add(new DamageItem());
                        break;
                    case 7:
                        chest.Add(new Protect());
                        break;
                    case 8:
                        chest.Add(new FullHeal());
                        break;
                }
            }
        }

        public static void Demonstrate(Character hero, Character monster)
        {
            Berserk offenseBuff = new Berserk();
            FullHeal uberHeal = new FullHeal();
            Protect defenseBuff = new Protect();
            Item[] demonstration = new Item[]
            {
                new DamageItem(), new Protect(), new FullHeal(), new Berserk()
            };
            Console.WriteLine("Test Subjects\n");
            Console.WriteLine(hero.ToString());
            Console.WriteLine(monster.ToString());

            Console.WriteLine("Demonstration Items\n");
            Console.WriteLine(PrintChest(demonstration));
            Console.WriteLine("||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
             foreach(IConsumable i in demonstration)
            {
                int charChoice = randomize.Next(2);
                switch(charChoice)
                {
                    case 0:
                        Console.WriteLine("\n" +hero.ToString() + "\n");
                        Console.WriteLine("=========");
                        Console.WriteLine(i.ToString());
                        Console.WriteLine("=========\n");
                        i.Use(hero);
                        Console.WriteLine("\n" + hero.ToString() + "\n");
                        Console.WriteLine("-----------------------------------------");
                        break;
                    case 1:
                        Console.WriteLine("\n" + monster.ToString() + "\n");
                        Console.WriteLine("=========");
                        Console.WriteLine(i.ToString());
                        Console.WriteLine("=========\n");
                        i.Use(monster);
                        Console.WriteLine("\n" +monster.ToString() + "\n");
                        Console.WriteLine("-----------------------------------------");
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

        private static string PrintChest(Item[] chest)
        {
            StringBuilder chestSB = new StringBuilder();
            foreach (var item in chest)
            {
                Console.WriteLine(item.ToString());
                Console.WriteLine("\n");
            }
            return chestSB.ToString();
        }
    }
}
