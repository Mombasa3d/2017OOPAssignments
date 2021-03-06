﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LootGenV2.Interfaces;
using LootGenV2;
using LootGenV2.Characters;

namespace LootGenV2.Items.Consumables
{
    class Protect : Item, IConsumable
    {
        private int protegaDef;
        private string[] variants = new string[] {
            "Mighty Guard", "Protect", "Shell", "Barrier"
        };


        public int ProtegaDef { get; }

        public Protect() : base()
        {
            Name = variants[rando.Next(variants.Length)];
            ProtegaDef = rando.Next(1, 7);
            Value = ProtegaDef * 15;
        }

        public string GetDescription()
        {
            return "Erects a protective barrier around the user, reducing damage taken.";
        }

        public void Use(Character input)
        {
            input.DamageReduction += ProtegaDef;
            Console.WriteLine("\n");
            Console.WriteLine(input.Name + " glows with a soft, protective light.");
        }

        public override string ToString()
        {
            return "===Protect Scroll===\n" +
                "- " + Name + "\n" +
                "- Damage Reduction: " + ProtegaDef + "\n" +
                "- Value: " + Value + "\n" +
                GetDescription();
        }
    }
}
