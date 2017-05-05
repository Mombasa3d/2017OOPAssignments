using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LootGenV1
{
    public class Potion : Item
    {
        Potion(int healing)
        {
            this.HealAmount = healing;
            new Item("Health Potion", healing / 10);
        }

        private int HealAmount { get; set; }
    }
}
