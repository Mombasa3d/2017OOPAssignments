using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LootGenV1
{
    public class Item
    {
        public string Name { get; set; }
        public int Value { get; set; }
        private static string[] itemNames = new string[]
        {
            "Black Bug Pellets", "Siegbrau", "Purple Moss Clump", "Black Firebomb", "Gold Pine Resin", "Homeward Bone", "Stalk Dung Pie"
        };
        public static Random rando = new Random();

        public Item(string name, int value)
        {
            Name = name;
            Value = value;
        }

        public Item()
        {
            Name = itemNames[rando.Next(itemNames.Length)];
            Value = rando.Next(25);
        }

        protected int normalize(int max, int min, int input)
        {
            if (input < min)
            {
                return min;
            }
            else if (input > max)
            {
                return max;
            }
            else
            {
                return input;
            }
        }

        public override string ToString()
        {
            StringBuilder potString = new StringBuilder();
            potString.Append("== Item ==\n");
            potString.Append("- Name: " + this.Name + "\n");
            potString.Append("- Value: " + this.Value);
            return potString.ToString();
        }
    }
}
