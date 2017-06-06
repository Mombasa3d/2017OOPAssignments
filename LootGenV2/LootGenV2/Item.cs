using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LootGenV2
{
    public class Item
    {
        private string name;
        private int value;

        public string Name { get => name; set => name = (string.IsNullOrWhiteSpace(value)) ? "Default" : value; }
        public int Value { get => value; set => this.value = (value < 0) ? 0 : value; }
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

        protected int Normalize(int max, int min, int input)
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
