using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LootGenV1
{
    class Armor : Item
    {
        protected int ArmorRating { get; set; }
        protected int DamageReduction { get; set; }
        protected int AgilityModifier { get; set; }
        private static string[] armorNames = new string[]
        {
            "Pontiff Knight Armor", "Court Sorceror Robes", "Xanthous Gear", "Grave Warden Armor", "Catarina Armor", "Havel's Armor"
        };

        public Armor(int ac, int reduction, int agiMod, string name, int value) : base(name, value)
        {
            ArmorRating = normalize(8, 17, ac);
            DamageReduction = normalize(0, 10, reduction);
            AgilityModifier = normalize(-6, 0, agiMod);
        }

        public Armor()
        {
            ArmorRating = normalize(8, 17, rando.Next(17));
            DamageReduction = normalize(0, 10, rando.Next(10));
            AgilityModifier = normalize(-6, 0, rando.Next(-7, 0));
            Item temp = new Item(armorNames[rando.Next(armorNames.Length)], rando.Next(10, 101));
            Name = temp.Name;
            Value = temp.Value;

        }
        public override string ToString()
        {
            StringBuilder potString = new StringBuilder();
            potString.Append("== Armor ==\n");
            potString.Append("- Name: " + this.Name + "\n");
            potString.Append("- Armor Rating: " + this.ArmorRating + "\n");
            potString.Append("- Damage Reduction: " + this.DamageReduction + "\n");
            potString.Append("- Agility Modifier: " + this.AgilityModifier + "\n");
            potString.Append("- Value: " + Value);
            return potString.ToString();
        }
    }
}
