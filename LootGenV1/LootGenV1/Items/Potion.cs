using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LootGenV1
{
    public class Potion : Item
    {
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
        private int HealAmount { get; set; }


        public override string ToString()
        {
            StringBuilder potString = new StringBuilder();
            potString.Append("== Potion ==\n");
            potString.Append("- Name: " + this.Name + "\n");
            potString.Append("- Restores " + this.HealAmount + " health\n");
            potString.Append("- Value: " + this.Value);
            return potString.ToString();
        }
    }
}
