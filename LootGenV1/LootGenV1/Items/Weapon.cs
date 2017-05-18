using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LootGenV1
{
    public class Weapon : Item
    {
        protected int DamageMax { get; set; }
        protected int DamageMin { get; set; }
        private string[] weaponNames = new string[]
        {
            "Notched Blade", "Heysel's Pick", "Demon's Fist", "Court Sorceror's Staff", "Astora Greatsword", "White Hair Talisman", "Moonlight Greatsword", "Dragonslayer Greatbow"
        };
        public Weapon(int min, int max, string name, int value) : base(name, value)
        {
            DamageMin = (min < 1) ? 1 : min;
            if(max < min)
            {
                DamageMax = min;
            }
            else if (max > 100)
            {
                DamageMax = 100;
            }
            else
            {
                DamageMax = max;
            }
        }

       public Weapon()
        {
            DamageMin = rando.Next(1, 101);
            DamageMax = rando.Next(DamageMin, 101);
            Item temp = new Item(weaponNames[(rando.Next(0, weaponNames.Length))], rando.Next(1, 501));
            Name = temp.Name;
            Value = temp.Value;

        }
        public override string ToString()
        {
            StringBuilder wepString = new StringBuilder();
            wepString.Append("== Weapon ==\n");
            wepString.Append("- Name: " + this.Name + "\n");
            wepString.Append("- Damage: " + this.DamageMin + " - " + this.DamageMax + "\n");
            wepString.Append("- Value: " + this.Value);
            return wepString.ToString();
        }
    }
}
