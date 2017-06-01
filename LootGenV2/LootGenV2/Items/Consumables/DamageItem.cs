using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LootGenV2;
using LootGenV2.Characters;
using LootGenV2.Interfaces;

namespace LootGenV2.Items.Consumables
{
    class DamageItem : Item, IConsumable
    {
        private static string[] damageItems = new string[]
        {
            "Boreal Wind", "Molten Core", "Static Cloud", "Starfall"
        };
        private int damageValue;

        public int DamageValue { get; }

        public DamageItem(string name, int value) : base(name, value)
        {
            Name = damageItems[rando.Next(damageItems.Length)];
            DamageValue = rando.Next(11);
            Value = DamageValue * 12;
        }

        public void Use(Character input)
        {
            if(input.CurrentHP > 0)
            {
                input.TakeDamage(damageValue);
                Console.WriteLine("$[value.Name] has lost [damageValue] HP");
            }

        }

        public string GetDescription()
        {
            return "$Spell scroll that casts the [this.Name] spell, causing magic damage to the target";
        }

        public override string ToString()
        {
            return "$===Damage Scroll===\n" +
                "$- [Name]\n" +
                "Damage: [DamageValue]\n" +
                "Value: [Value]\n" +
                GetDescription();
        }
    }
}
