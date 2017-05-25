using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LootGenV2.Interfaces;
using LootGenV2.Characters;

namespace LootGenV2
{
    public class Potion : Item , IConsumable
    {
        private int healAmount;
        public int HealAmount { get; set; }

        public Potion(int healing)
        {
            HealAmount = healing;
            new Item("Health Potion", healing / 10);
        }

        public Potion() 
        {
            HealAmount = rando.Next(10, 101);
            Item temp = new Item("Health Potion", HealAmount / 10);
            Name = temp.Name;
            Value = temp.Value;
        }



        public override string ToString()
        {
            StringBuilder potString = new StringBuilder();
            potString.Append("== Potion ==\n");
            potString.Append("- Name: " + this.Name + "\n");
            potString.Append("- Restores " + this.HealAmount + " health\n");
            potString.Append("- Value: " + this.Value);
            return potString.ToString();
        }

        public void Use(Character input)
        {
            if (input.CurrentHP >= 1)
            {
                input.CurrentHP = (input.BaseHP + this.HealAmount > input.BaseHP) ? input.BaseHP : input.BaseHP + this.HealAmount;
            }
            else
            {
                Console.WriteLine(input.Name + " is dead, they cannot be healed!");
            }
        }

        public string GetDescription()
        {
            throw new NotImplementedException();
        }
    }
}
