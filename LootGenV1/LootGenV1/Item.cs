using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LootGenV1
{
    public class Item
    {
        protected string Name { get; set; }
        protected int Value { get; set; }
        public static Random rando = new Random();

        public Item(string name, int value)
        {
            Name = name;
            Value = value;
        }

        public Item()
        {
            //Name = 
        }
    }
}
