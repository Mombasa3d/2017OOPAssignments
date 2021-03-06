﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LootGenV2
{
    public class Armor : Item
    {
        protected int armorRating;
        protected int damageReduction;
        protected int agilityModifier;
        private static string[] armorNames = new string[]
        {
            "Pontiff Knight Armor", "Court Sorceror Robes", "Xanthous Gear", "Grave Warden Armor", "Catarina Armor", "Havel's Armor"
        };

        //Props
        public int ArmorRating { get; set; }
        public int DamageReduction { get; set; }
        public int AgilityModifier { get; set; }

        //Constr

        public Armor(int ac, int reduction, int agiMod, string name, int value) : base(name, value)
        {
            ArmorRating = Normalize(8, 17, ac);
            DamageReduction = Normalize(0, 10, reduction);
            AgilityModifier = Normalize(-15, -3, agiMod);
        }

        public Armor()
        {
            ArmorRating = Normalize(8, 17, rando.Next(17));
            DamageReduction = Normalize(0, 10, rando.Next(10));
            AgilityModifier = Normalize(-15, -3, rando.Next(-7, 0));
            Item temp = new Item(armorNames[rando.Next(armorNames.Length)], rando.Next(10, 101));
            Name = temp.Name;
            Value = temp.Value;

        }

        //Methods

        public override string ToString()
        {
            StringBuilder potString = new StringBuilder();
            potString.Append("== Armor ==\n");
            potString.Append("- Name: " + Name + "\n");
            potString.Append("- Armor Rating: " + ArmorRating + "\n");
            potString.Append("- DR: " + DamageReduction + "\n");
            potString.Append("- Agility Modifier: " + AgilityModifier + "\n");
            potString.Append("- Value: " + Value);
            return potString.ToString();
        }
    }
}
